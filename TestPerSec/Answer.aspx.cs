using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestPerSec.Class;

namespace TestPerSec
{
    public partial class Answer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected int SquareDigits(int n)
        {
            string value = n.ToString();
            int index = value.Length;
            string Ans = "";

            for (int i = 0; i < index; i++)
            {
                Ans += Math.Pow(Convert.ToDouble(value[i].ToString()), 2).ToString();
            }

            return int.Parse(Ans);
        }

        protected string reverse(string value)
        {
            int index = value.Length;
            int u = (index - 1);
            string Ans = "";

            for (int i = 0; i < index; i++)
            {
                Ans += value[u].ToString();
                u--;
            }

            return Ans;
        }

        protected string score(string word)
        {
            string[] atoz = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] value = word.Split(' ');
            string ans = "";
            int oldsum = 0;
            for (int i = 0; i < value.Count(); i++)
            {
                int sum = 0;
                string w = value[i];
                for (int u = 0; u < w.Length; u++)
                {
                    var index = atoz.ToList().IndexOf(w[u].ToString());
                    sum = sum + (index + 1);
                }
                if (oldsum < sum)
                {
                    ans = w;
                    oldsum = sum;
                }
            }
            return ans;
        }

        protected void btnsend11_Click(object sender, EventArgs e)
        {
            var asn11 = OddEvenList.add<string>(txtAns11.Text);
            lblans11.Text = asn11.ToString();
        }

        protected void btnsend12_Click(object sender, EventArgs e)
        {
            try
            {
                var ans12 = OddEvenList.remove(int.Parse(txtAns12.Text));
                lblans12.Text = ans12.ToString();
            }
            catch
            {
                lblans12.Text = "false";
            }
        }

        protected void btnsend13_Click(object sender, EventArgs e)
        {
            var ans13 = OddEvenList.getOdd<string>();
            string ans = "";
            for (int i = 0; i < ans13.Length; i++)
            {
                ans += ans13.GetValue(i).ToString();
                ans += (i + 1) < ans13.Length ? "," : "";
            }
            lblans13.Text = ans;
        }

        protected void btnsend14_Click(object sender, EventArgs e)
        {
            var ans14 = OddEvenList.getEven<string>();
            string ans = "";
            for (int i = 0; i < ans14.Length; i++)
            {
                ans += ans14.GetValue(i).ToString();
                ans += (i + 1) < ans14.Length ? "," : "";
            }
            lblans14.Text = ans;
        }

        protected void btnsend15_Click(object sender, EventArgs e)
        {
            var ans15 = OddEvenList.getRandom<string>();
            string ans = "";
            for (int i = 0; i < ans15.Length; i++)
            {
                ans += ans15.GetValue(i).ToString();
                ans += (i + 1) < ans15.Length ? "," : "";
            }
            lblans15.Text = ans;
        }

        protected void btnsend2_Click(object sender, EventArgs e)
        {
            try
            {
                var ans = SquareDigits(int.Parse(txtAns2.Text));
                lblans2.Text = ans.ToString(); ;
            }
            catch
            {

            }
        }

        protected void btnsend3_Click(object sender, EventArgs e)
        {
            var ans = reverse(txtAns3.Text);
            lblans3.Text = ans.ToString();
        }

        protected void btnsend4_Click(object sender, EventArgs e)
        {
            var ans = score(txtAns4.Text);
            lblans4.Text = ans.ToString();
        }

    }
}