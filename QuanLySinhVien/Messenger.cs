using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLySinhVien
{
    public partial class Messenger : Form
    {
        String sender_id;
        String receiver_id;
        bool flag= true;
        private string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
        public Messenger(String sender_id, String receiver_id)
        {
            InitializeComponent();
            this.sender_id=sender_id;
            this.receiver_id=receiver_id;
            flowLayoutPanelMessages.AutoScroll = true;
            LoadMessages();            
        }
        

        private void LoadMessages()
        {
            flowLayoutPanelMessages.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT SenderId, ReceiverId, MessageText, SentAt 
                FROM Messages
                WHERE (SenderId = @sender_id AND ReceiverId = @receiver_id)
                   OR (SenderId = @receiver_id AND ReceiverId = @sender_id)
                ORDER BY SentAt";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@sender_id", sender_id);
                        cmd.Parameters.AddWithValue("@receiver_id", receiver_id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string sender = reader["SenderId"].ToString();
                                string message = reader["SentAt"].ToString()+reader["MessageText"].ToString();
                                bool isSender = (sender == sender_id);

                                AddMessageToPanel(EditMessage(message), isSender);
                            }
                        }

                    }
                }
                // Cuộn xuống dưới cùng sau khi tải xong tin nhắn
                flowLayoutPanelMessages.AutoScrollPosition = new Point(0, flowLayoutPanelMessages.VerticalScroll.Maximum);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải tin nhắn. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddMessageToPanel(string message, bool flag)
        {

            Panel messagePanel = new Panel
            {
                AutoSize = true,
                Padding = new Padding(10),
                Margin = new Padding(5),
            };

            // Tạo Label hiển thị tin nhắn
            Label messageLabel = new Label
            {
                Text = message,
                AutoSize = true,
                ForeColor = Color.Black,
                Dock = DockStyle.Fill,
            };

            messagePanel.Controls.Add(messageLabel);


            
            messagePanel.BackColor = flag ? Color.LightBlue : Color.LightGreen;
            messagePanel.Margin = flag ? new Padding(150, 5, 5, 5) : new Padding(5, 5, 150, 5);
            
            flowLayoutPanelMessages.Controls.Add(messagePanel);
        }
        private string EditMessage(string input)
        {
            string firstPart = input.Substring(0, Math.Min(13, input.Length)).Trim();

            string secondPart = input.Length > 16 ? input.Substring(21).Trim() : string.Empty;
            int count = 0;
            for (int i = 0; i < secondPart.Length; i++)
            {
                count += 1;
                if (count >= 28)
                {
                    if (secondPart[i].ToString() == " " || count == 33)
                    {
                        secondPart = secondPart.Substring(0, i) + '\n' + secondPart.Substring(i + 1);
                        count = 0;
                    }
                }
            }
            return $"{firstPart}\n{secondPart}";
        }



        private void send_message_Click(object sender, EventArgs e)
        {
            string messageText = text_input.Text.Trim();

            if (string.IsNullOrEmpty(messageText))
            {
                MessageBox.Show("Vui lòng nhập nội dung tin nhắn.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                INSERT INTO Messages (SenderId, ReceiverId, MessageText, SentAt, IsRead)
                VALUES (@SenderId, @ReceiverId, @MessageText, @SentAt, @IsRead)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SenderId", sender_id);
                        cmd.Parameters.AddWithValue("@ReceiverId", receiver_id);
                        cmd.Parameters.AddWithValue("@MessageText", messageText);
                        cmd.Parameters.AddWithValue("@SentAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@IsRead", false);

                        cmd.ExecuteNonQuery();
                    }
                }

                text_input.Clear();
                LoadMessages();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể gửi tin nhắn. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_reset_Click(object sender, EventArgs e)
        {
            LoadMessages();
        }

        private void flowLayoutPanelMessages_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
