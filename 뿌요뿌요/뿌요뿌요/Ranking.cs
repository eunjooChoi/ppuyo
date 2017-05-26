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

namespace 뿌요뿌요
{
    public partial class Ranking : Form
    {
        public int score;   //점수를 저장하는 변수 --> 메인폼에서 게임이 끝나면 클래스 인스턴스에 점수 넣어줌
        public string name;
        private StreamReader read;      //
        private FileStream f;           //파일에 스트림을 하기 위한 변수들
        private List<string> readString = new List<string>();   //파일에서 불러온 문자열을 저장할 List
        private ranking data = new ranking();     //데이터셋 생성


        public Ranking()
        {
            InitializeComponent();
        }

        private void Ranking_Load(object sender, EventArgs e) //폼 로드시
        {
            int index = 0;
            try
            {
                string str = "";
                f = new FileStream(Application.StartupPath + @"\Rank.txt", FileMode.Open);//파일을 열고
                read = new StreamReader(f);
                //write = new StreamWriter(f);    //스트림 초기화

                while (str != null)
                {
                    str = read.ReadLine();  //파일을 한 줄 읽어서
                    if (str == null)
                        break;
                    readString.Add(str);    //문자열을 List에 추가
                    index++;
                }

                index = 0;

                if (readString == null)     //파일에 아무것도 없다면 밑의 행동을 할 필요가 없음 --> return
                    return;

                foreach (string s in readString)
                {
                    string[] split;
                    split = s.Split('|');       //split 메소드를 통해서 string 배열에 이름과 점수 나눠서 저장
                    data.Tables["ranking"].Rows.Add(new object[] { split[0], Convert.ToInt32(split[1]) });    //나눈 문자열을 데이터테이블에 추가
                }

                DataTable values = data.Tables["ranking"];

                IEnumerable<DataRow> query =    //데이터셋에 추가된 테이터들을 query와 orderby절을 통해 높은점수부터 query에 저장
                    from score in values.AsEnumerable()
                    orderby Convert.ToInt32(score["score"]) descending
                    select score;

                int i = 0;

                foreach (DataRow dr in query)    //query에 있는 tuple들을 위에서부터 5개만 출력
                {
                    i++;
                    this.textBox1.AppendText(i + ". Name : " + dr["name"].ToString() + "     Score : " + dr["score"] + "\n");
                    if (i == 15)
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            read.Close();
            f.Dispose();
            f.Close();  //리소스 해제
            this.Close();
        }
    }
}