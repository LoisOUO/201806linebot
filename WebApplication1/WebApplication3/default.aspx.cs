using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "wViS2NyjED7KQ+v20R68QvBVbSggjsHpsYtVSH8DoL+3y2YWiPwNT/m1QpUzpi73/fd2MzGhSKjONcwJLyt0y6lNW/JuyZyPjNOt3GTdiflCxPh0UI1V3x5oGlh7uAuepnlhYsrG7FVObg3CHAU9bAdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "U26dd87213fa1f3d11d0a0a4d57a54cb5";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,3);

            //isRock.LineBot.Bot bot = new isRock.LineBot.Bot("CVfzZeskAfcQeyevyc7k4bBONPU3oCtT0oydYm9MrDXKYK2oHC0KtjGF1wAjogrhrKM42B3Fu7DWHFNzEC9rDliPH09/3uAkIDXarQpSMACeX8fupBUpZXamhLdWsO+/PaQFpBoWHSYhRYXK6DmNUAdB04t89/1O/w1cDnyilFU=");
            //bot.PushMessage("U26dd87213fa1f3d11d0a0a4d57a54cb5", "!!!!");
            //bot.PushMessage("U26dd87213fa1f3d11d0a0a4d57a54cb5", 1, 2);
            //bot.PushMessage("U26dd87213fa1f3d11d0a0a4d57a54cb5", new Uri("https://i1.wp.com/storage.googleapis.com/petsmao-images/images/2017/10/c235445f7b255b5b.jpg?fit=600%2C450&ssl=1"));

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId,"hello");
            bot.PushMessage(AdminUserId, new Uri("https://img.ifun01.com/images/2017/12/21/02/3252_FcKYsi_3PI5fK.jpeg!r800x0.jpg"));
        }
    }
}