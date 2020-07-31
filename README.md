# Official Discord REQ API

An easily usable discord API for making selfbots, software handling discord in general. Here is a diagram representing the current functionalities

# How to use ?

* Friend
  * AddFriend
    * `Discord.REQ.Friend.AddFriend("id", "token");`
  * RemoveFriend
    * `Discord.REQ.Friend.RemoveFriend("id", "token");`
  * BlockFriend
    * `Discord.REQ.Friend.BlockFriend("id", "token");`
* Message
  * Send Message
    * `Discord.REQ.Message.SendMessage("Hello world", "chanid", "token");`
  * Delete Message
    * `Discord.REQ.Message.DeleteMessage("chanid", "msgid", "token");`
  * Typing
    * `Discord.REQ.Message.Typing("channelid", "token");`
  * Pins Message
    * `Discord.REQ.Message.PinsMessage("channel id", "msgid", "token");`
* UserProfil
  * Set IDLE
    * `Discord.REQ.UserProfile.SetIdle("token");`
  * Set Online
    * `Discord.REQ.UserProfile.SetOnline("token");`
  * Set DND
    * `Discord.REQ.UserProfile.SetDND("token");`
  * Set Offline
    * `Discord.REQ.UserProfile.SetOffline("Username", "Email", "Password", "Tag", "Token");`
  * Set Username
    * `Discord.REQ.UserProfile.SetUsername("Username", "Email", "Password", "Tag", "Token");`
* Guild
  * Leave Guild
    * `Discord.REQ.UserServer.LeaveServer("guildid", "token");`
  * Join Guild
    * `Discord.REQ.UserServer.JoinServer("InviteCode", "token");`
  * Create Guild
    * `Discord.REQ.UserServer.CreateServer("Name", "token");`
  * Delete Guild
    * `Discord.REQ.UserServer.DeleteServer("Server id", "Token");`
* Webhook 
  * Create Webhook
    * `Discord.REQ.Webhook.CreateWebhook("Chan id", "token");`
  * Delete Webhook
    * `Discord.REQ.Webhook.DeleteWebhook("Server id", "Token");`
