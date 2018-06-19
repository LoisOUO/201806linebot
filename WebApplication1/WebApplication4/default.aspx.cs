using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "wViS2NyjED7KQ+v20R68QvBVbSggjsHpsYtVSH8DoL+3y2YWiPwNT/m1QpUzpi73/fd2MzGhSKjONcwJLyt0y6lNW/JuyZyPjNOt3GTdiflCxPh0UI1V3x5oGlh7uAuepnlhYsrG7FVObg3CHAU9bAdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId = "U26dd87213fa1f3d11d0a0a4d57a54cb5";

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
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}