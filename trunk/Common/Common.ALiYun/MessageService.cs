using Aliyun.SmsApi.Model;
using Aliyuncs;
using Aliyuncs.Profile;
using Common.Logging;
using Core.EnumType;
using System;
using System.Configuration;

namespace Common.ALiYun
{
    public class MessageHelper
    {
        public MessageHelper()
        {
            this.SignName = ConfigurationManager.AppSettings["SignName"];
            this.AccessKeyId = ConfigurationManager.AppSettings["AccessKeyId"];
            this.AccessKeySecret = ConfigurationManager.AppSettings["AccessKeySecret"];
        }

        /// <summary>
        /// 必填:短信签名
        /// </summary>
        public string SignName { get;}
        /// <summary>
        /// 开发者自己的AK
        /// </summary>
        public string AccessKeyId { get; }
        /// <summary>
        /// 开发者自己的AK(密钥)
        /// </summary>
        public string AccessKeySecret { get; }

        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="phoneNumbers"> 短信接收者（多个以英文逗号隔开）</param>
        /// <param name="templateCode">短信模板</param>
        /// <param name="templateParam">短信模板参数(如模板内容为"亲爱的${name},您的验证码为${code}"时,此处的值为:{\"name\":\"提现\", \"code\":\"5456\"})</param>
        /// <returns></returns>
        public SendSmsResponse SendMessage( string phoneNumbers,string templateCode,string templateParam)
        {
            // 初始化acsClient,暂不支持region化
            IClientProfile profile = DefaultProfile.GetProfile("cn-shenzhen", AccessKeyId, AccessKeySecret);
            DefaultProfile.AddEndpoint("cn-shenzhen", "cn-shenzhen", "Dysmsapi", "dysmsapi.aliyuncs.com");
            IAcsClient acsClient = new DefaultAcsClient(profile);

            // 组装请求对象-具体描述见控制台-文档部分内容
            SendSmsRequest request = new SendSmsRequest();
            // 必填:待发送手机号
            request.PhoneNumbers = phoneNumbers;
            // 必填:短信签名-可在短信控制台中找到
            request.SignName = SignName;
            // 必填:短信模板-可在短信控制台中找到
            request.TemplateCode = templateCode;
            // 可选:模板中的变量替换JSON串,如模板内容为"亲爱的${name},您的验证码为${code}"时,此处的值为
            request.TemplateParam = templateParam;
            // 可选:outId为提供给业务方扩展字段,最终在短信回执消息中将此值带回给调用者
            // request.setOutId("yourOutId");

            // hint 此处可能会抛出异常，注意catch
            SendSmsResponse sendSmsResponse = null;
            try
            {
                sendSmsResponse = acsClient.GetAcsResponse(request);
            }
            catch (Exception ex) {
                Log.Error($"发送短信失败：{$"收信人：{phoneNumbers}"};短信模板：{templateCode};模板参数：{templateParam}; 异常信息：{ex.Message}");
                sendSmsResponse.Code = StatusCodeEnum.Error.ToString();
                sendSmsResponse.Message = $"短信发送失败。{ex.ToString()} ";
            }

            return sendSmsResponse;
        }
    }
}
