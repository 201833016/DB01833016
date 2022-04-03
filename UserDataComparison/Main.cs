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
    public partial class Main : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=userdata1;Uid=root;Pwd=test1234;");
        // 서버 정보

        private string itemSelected;
        private RadioButton checkedRB;

        public static string uName;
        public static string uId;
        public Main()
        {
            InitializeComponent();
            fillcombo();
        }

        // 성별
        private void radioButton_Male_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = radioButton_Male;
            label_gender_value.Text = radioButton_Male.Text;    // label에 성별값을 집어 넣는다.
        }
        private void radioButton_Female_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = radioButton_Female;
            label_gender_value.Text = radioButton_Female.Text;  // label에 성별값을 집어 넣는다.
        }

        // comboBox에 넣을 것들
        private void Main_Load(object sender, EventArgs e)
        {
            label_ID.Text = uId;
            textBox_Name.Text = uName;
            /*
            // 콤보 박스에 넣을 값
            string[] birth = { "1월", "2월", "3월", "4월", "5월", "6월", "7월", "8월", "9월", "10월", "11월", "12월" };
            string[] hobby = { "운동", "실내활동", "여행", "전문기술", "공부", "그외 취미"};
            string[] address = { "서울특별시", "경기도", "강원도", "충청북도", "충청남도", "전라북도", "전라남도", "경상북도", "경상남도", "제주특별자치도", "해외 거주" };
            string[] religion = {"기독교", "불교", "유교", "천주교", "이슬람교","그외 종교", "종교없음" };
            string[] MBTI = {"ISTJ", "ISTP", "ISFJ", "ISFP", "INTJ", "INTP", "INFJ", "INFP", "ESTJ", "ESTP", "ESFJ", "ESFP", "ENTJ", "ENTP", "ENFJ", "ENFP"};

            // 각 콤보박스에 데이타를 초기화
            comboBox_birth_month.Items.AddRange(birth);
            comboBox_Hobby.Items.AddRange(hobby);
            comboBox_address.Items.AddRange(address);
            comboBox_religion.Items.AddRange(religion);
            comboBox_MBTI.Items.AddRange(MBTI);
            
            */

            // 처음 선택값 지정. 첫째 아이템 선택
            // comboBox_birth_month.SelectedIndex = 0;
        }

        //생일(월) 콤보박스
        private void comboBox_birth_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_birth_month.SelectedIndex >= 0)
            {
                this.itemSelected = comboBox_birth_month.SelectedItem as string;
            }
        }

        // 취미 콤보박스
        private void comboBox_Hobby_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox_Hobby.SelectedIndex >= 0)
            {
                this.itemSelected = comboBox_Hobby.SelectedItem as string;
            }
        }

        // 거주지 콤보박스
        private void comboBox_address_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_address.SelectedIndex >= 0)
            {
                this.itemSelected = comboBox_address.SelectedItem as string;
            }
        }

        // 종교 콤보박스
        private void comboBox_religion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_religion.SelectedIndex >= 0)
            {
                this.itemSelected = comboBox_religion.SelectedItem as string;
            }
        }

        // MBTI 콤보박스
        private void comboBox_MBTI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_MBTI.SelectedIndex >= 0)
            {
                this.itemSelected = comboBox_MBTI.SelectedItem as string;
            }
        }

        // 제출 번호 클릭시
        private void button_Submission_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO memberdata(id, name, gender,age,birth, hobby, address, religion, mbti) VALUES('"+ label_ID.Text +"', '"+ textBox_Name.Text +"', '" + label_gender_value.Text + "', '" + comboBox_Age.Text + "', '" + comboBox_birth_month.Text + "', '" + comboBox_Hobby.Text +"', '" + comboBox_address.Text + "', '" + comboBox_religion.Text + "', '" + comboBox_MBTI.Text + "')";
            // userdata_tb 테이블에 해당 text값을 column에 삽입

            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try//예외 처리
            {
                // 만약 Mysql에 정상적으로 들어갔다면 
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("해당 정보를 수집하였습니다.");
                }
                else
                {
                    MessageBox.Show("실패하였습니다. 잘못한 것은 없는지 확인하여 주십시오");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        void fillcombo()
        {
            string constring = "Server=localhost;Database=userdata1;Uid=root;Pwd=test1234;";
            string Query = "select * from userdata1.privacy";
            
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand mySqlCommand = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = mySqlCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string sAge = myReader.GetString("age");
                    comboBox_Age.Items.Add(sAge);
                    string sBirth = myReader.GetString("birth");
                    comboBox_birth_month.Items.Add(sBirth);
                    string sHobby = myReader.GetString("hobby");
                    comboBox_Hobby.Items.Add(sHobby);
                    string sAddress = myReader.GetString("address");
                    comboBox_address.Items.Add(sAddress);
                    string sReligion = myReader.GetString("religion");
                    comboBox_religion.Items.Add(sReligion);
                    string sMBTI = myReader.GetString("mbti");
                    comboBox_MBTI.Items.Add(sMBTI);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
