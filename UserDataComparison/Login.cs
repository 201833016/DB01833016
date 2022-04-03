using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  //참조로 추가한다

namespace UserDataComparison
{
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=userdata1;Uid=root;Pwd=test1234;");
        // 서버 정보

        // private string itemSelected;
        // private RadioButton checkedRB;

        public Login()
        {
            InitializeComponent();
        }

        private bool EmptyCheck() 
        { 
            if (String.IsNullOrEmpty(textBox_ID.Text)) 
            {
                MessageBox.Show("아이디를 입력해 주세요", "로그인 오류", MessageBoxButtons.OK, MessageBoxIcon.Question);
                textBox_ID.Focus(); 
                return false; 
            } 
            else if (String.IsNullOrEmpty(textBox_Name.Text)) 
            {
                MessageBox.Show("이름를 입력해 주세요", "로그인 오류", MessageBoxButtons.OK, MessageBoxIcon.Question);
                textBox_Name.Focus(); 
                return false;
            } 
            return true; 
        
        }
        private void button_Login_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO userdata_tb(id,name) VALUES('" + textBox_ID.Text + "', '" + textBox_Name.Text + "')";
            // userdata_tb 테이블에 해당 text값을 column에 삽입

            string id = textBox_ID.Text;
            string name = textBox_Name.Text;

            if (textBox_ID.Text.Trim() == "")
            {
                MessageBox.Show("아이디를 입력하시오");
            }
            else if (textBox_Name.Text.Trim() == "")
            {
                MessageBox.Show("이름를 입력하시오");
            }
            else
            {
                if (textBox_ID.Text == "admin" && textBox_Name.Text == "1234")
                {
                    // 관리자 코드 입력시
                    MessageBox.Show("로그인 되었습니다.");

                    Main showMain = new Main();         // 추후 관리자 페이지 생성후, 변경예정
                    this.Visible = false;             // 현재 창(Window)를 닫기
                    showMain.ShowDialog();
                }
                else
                {
                    connection.Open();
                    try
                    {
                        // DB에 존재하는 값으로 로그인 시
                        string sql = "select * from userdata_tb where id ='" + textBox_ID.Text + "' ";
                        MySqlCommand command = new MySqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            if (reader["id"].ToString() == textBox_ID.Text && reader["name"].ToString() == textBox_Name.Text)
                            {
                                Main.uId = reader["id"].ToString();
                                Main.uName = reader["name"].ToString();

                                MessageBox.Show("환영합니다");

                                Main showMain = new Main();
                                this.Visible = false;             // 현재 창(Window)를 닫기
                                showMain.ShowDialog();
                            }
                            else if (reader["name"].ToString() == textBox_ID.Text)
                            {
                                MessageBox.Show("이름이 일치하지 않습니다.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("존재하지 않는 회원입니다. 새로 만드시겠습니까?");
                        }

                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
    
}
