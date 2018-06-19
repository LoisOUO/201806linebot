using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4.Controllers
{
    public class LineBotWebHookController : isRock.LineBot.LineWebHookControllerBase
    {
        const string channelAccessToken = "wViS2NyjED7KQ+v20R68QvBVbSggjsHpsYtVSH8DoL+3y2YWiPwNT/m1QpUzpi73/fd2MzGhSKjONcwJLyt0y6lNW/JuyZyPjNOt3GTdiflCxPh0UI1V3x5oGlh7uAuepnlhYsrG7FVObg3CHAU9bAdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId = "U26dd87213fa1f3d11d0a0a4d57a54cb5";

        [Route("api/LineWebHookSample")]
        [HttpPost]
        public IHttpActionResult POST()
        {
            try
            {
                //設定ChannelAccessToken(或抓取Web.Config)
                this.ChannelAccessToken = channelAccessToken;
                //取得Line Event(範例，只取第一個)
                var LineEvent = this.ReceivedMessage.events.FirstOrDefault();
                //配合Line verify 
                if (LineEvent.replyToken == "00000000000000000000000000000000") return Ok();
                //回覆訊息
                if (LineEvent.type == "message")
                {
                    if (LineEvent.message.type == "text") //收到文字
                        this.ReplyMessage(LineEvent.replyToken, "你說了:" + LineEvent.message.text);
                    if (LineEvent.message.type == "sticker") //收到貼圖
                        this.ReplyMessage(LineEvent.replyToken, 1, 2);
                }
                //response OK
                return Ok();
             /*   //----------------------------//
                //設定ChannelAccessToken(或抓取Web.Config)
                this.ChannelAccessToken = channelAccessToken;
                //取得Line Event(範例，只取第一個)
                var LineEvent = this.ReceivedMessage.events.FirstOrDefault();
                //配合Line verify 
                if (LineEvent.replyToken == "00000000000000000000000000000000") return Ok();
                //回覆訊息
                //var UrseName= this.PushMessage(LineEvent.source.userId,"XXX"); //找個人的userID 私訊
                //去抓資料庫
                //this.GetUserInfo();
                isRock.LineBot.Bot bot = new isRock.LineBot.Bot(channelAccessToken);
                string LineId = ReceivedMessage.events.FirstOrDefault().source.userId;
                var userInfo = bot.GetUserInfo(LineId);
                if (LineEvent.type == "message")
                {
                    //this.ReplyMessage(LineEvent.replyToken,"我可以回答任何問題~" + LineEvent.message.text+ userInfo);
                    if (LineEvent.message.type == "text")//收到文字 
                    {
                        string str = userInfo.displayName;

                        if (LineEvent.message.text.Contains("hello"))
                            str += "~hello";

                        if (LineEvent.message.text.Contains("畢業門檻"))
                            str += "，系必修有60學分，選修要28學分，核心要記得各領域各一個，通識10學分";

                        if (LineEvent.message.text.Contains("必修"))
                            str += "，系上必修60學分，英文6學分";

                        if (LineEvent.message.text.Contains("選課") || LineEvent.message.text.Contains("選修"))
                            str += "，已經超過選課時間了";

                        if (LineEvent.message.text.Contains("退選") || LineEvent.message.text.Contains("二退"))
                            str += " ，今年的二退時間已過，還沒退就認真上完吧";


                        if (str.Length <= userInfo.displayName.Length + 10)
                        {
                            str += "，你可以問選課的事情。";
                        }
                        this.ReplyMessage(LineEvent.replyToken, str + "~");
                    }

                    if (LineEvent.message.type == "sticker") //收到貼圖
                        this.ReplyMessage(LineEvent.replyToken, 1, 2);


                }
                //response OK
                return Ok();
                //----------------------------//*/
            }
            catch (Exception ex)
            {
                //如果發生錯誤，傳訊息給Admin
                this.PushMessage(AdminUserId, "發生錯誤:\n" + ex.Message);
                //response OK
                return Ok();
            }
        }
    }
}
