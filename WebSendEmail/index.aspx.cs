using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSendEmail
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string address = Request.Form["TxtEmail"].Trim();
            string subject = Request.Form["TxtSubject"].Trim();
            string body = Request.Form["TxtBody"].Trim();


            if (address.Length==0 && subject.Length == 0 && body.Length == 0)
            {

                result.ForeColor = Color.Red;
                result.Font.Bold = true;
                result.Text = "Fill in all fields";
            }
            else
            {
                Email em = new Email();
            em.subject = subject;
            em.body = body;
            em.toList = address;
            em.ccList = "anicetkeric@outlook.com";

                string res = utils.SendMail(em);

                if (res == "1")
                {
                    result.ForeColor = Color.Green;
                    result.Font.Bold = true;
                    result.Text = "email send";
                }
                else result.Text = res;
            }
            
        }
    }
}