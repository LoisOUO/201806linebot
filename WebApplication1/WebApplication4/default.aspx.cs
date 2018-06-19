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
        //  string str = userInfo.displayName;

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
            bot.PushMessage(AdminUserId, 1, 2);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageAction() { label = "標題 文字回復", text = "回復文字" });
            actions.Add(new isRock.LineBot.UriAction() { label = "標題 開啟URI", uri = new Uri("http://www.google.com") });
            actions.Add(new isRock.LineBot.PostbackAction() { label = "標題 發生postack", data = "abc=aaa&def=111" });
            var bot = new Bot(channelAccessToken);
            var ButtonTempalteMsg = new isRock.LineBot.ButtonsTemplate()
            {
                //altText
                title = "選項",
                text = "請選擇一個",
                altText = "請在手機上檢視",
                thumbnailImageUrl = new Uri("https://img.ifun01.com/images/2017/12/21/02/3252_FcKYsi_3PI5fK.jpeg!r800x0.jpg"),
                actions = actions
            };
            bot.PushMessage(AdminUserId, ButtonTempalteMsg);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageAction() { label = "Yes", text = "Yes" });
            actions.Add(new isRock.LineBot.MessageAction() { label = "No", text = "No" });

            var ConfirmTemplate = new isRock.LineBot.ConfirmTemplate()
            {

                text = "請選擇一個",
                altText = "請在手機上檢視",
                actions = actions
            };
            bot.PushMessage(AdminUserId, ConfirmTemplate);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageAction() { label = "標題 文字回復", text = "回復文字" });
            actions.Add(new isRock.LineBot.UriAction() { label = "標題 開啟URI", uri = new Uri("http://www.google.com") });
            actions.Add(new isRock.LineBot.PostbackAction() { label = "標題 發生postack", data = "abc=aaa&def=111" });
            var bot = new Bot(channelAccessToken);
            var Column = new isRock.LineBot.Column()
            {
                //altText
                title = "選項",
                text = "請選擇一個",
                //altText = "請在手機上檢視",
                thumbnailImageUrl = new Uri("https://img.ifun01.com/images/2017/12/21/02/3252_FcKYsi_3PI5fK.jpeg!r800x0.jpg"),
                actions = actions
            };
            var CarouselTemplate = new isRock.LineBot.CarouselTemplate();
            CarouselTemplate.columns.Add(Column);
            CarouselTemplate.columns.Add(Column);
            CarouselTemplate.columns.Add(Column);
            bot.PushMessage(AdminUserId, CarouselTemplate);
        }
    }
}