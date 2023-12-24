
using NoDirectCoupling;

var emailNotifier = new SendEmailNotification();
var smsNotifier = new SendSMSNotification();

ISendNotification notifyByMail = new SendEmailNotification();
ISendNotification notifyBySMS = new SendSMSNotification();

notifyByMail.SendNotificationToUser("Hello from email!");
notifyBySMS.SendNotificationToUser("Hello from sms!");

