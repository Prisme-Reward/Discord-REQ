# Official Discord REQ API

An easily usable discord API for making bots, software handling discord in general. Here is a diagram representing the current functionalities. Website [**here**](https://discord-req.github.io/)<br>

# Download

 Click [**here**](https://www.nuget.org/packages/DiscordREQ)<br>(pre releases)

# How to use ?

* Friend
  * AddFriend
    * `Discord.REQ.RelationShip.AddFriend("id", "token");`
  * RemoveFriend
    * `Discord.REQ.RelationShip.RemoveFriend("id", "token");`
  * BlockFriend
    * `Discord.REQ.RelationShip.BlockUser("id", "token");`
  * Unblock
    * `Discord.REQ.RelationShip.UnblocUser("id", "token");`
* Message
  * Send Message
    * `Discord.REQ.Message.Send("Hello world", "chanid", "token");`
  * Delete Message
    * `Discord.REQ.Message.Delete("chanid", "msgid", "token");`
  * Typing
    * `Discord.REQ.Message.Typing("channelid", "token");`
  * Pins Message
    * `Discord.REQ.Message.Pins("channel id", "msgid", "token");`
* UserProfil
  * Set IDLE
    * `Discord.REQ.UserProfile.SetIdle("token");`
  * Set Online
    * `Discord.REQ.UserProfile.SetOnline("token");`
  * Set DND
    * `Discord.REQ.UserProfile.SetDND("token");`
  * Set Offline
    * `Discord.REQ.UserProfile.SetOffline("Token");`
  * Set Username
    * `Discord.REQ.UserProfile.SetUsername("Token");`
  * Set Status
    * `Discord.REQ.UserProfile.SetStatus("text", "emoji", "token");`
  * Set NitroStatus
    * `Discord.REQ.UserProfile.SetNitroStatus("text", "emojiname", "emoji id", "Token");`
* Guild
  * Leave Guild
    * `Discord.REQ.UserServer.Leave("guildid", "token");`
  * Join Guild
    * `Discord.REQ.UserServer.Join("InviteCode", "token");`
  * Create Guild
    * `Discord.REQ.UserServer.Create("Name", "token");`
  * Delete Guild
    * `Discord.REQ.UserServer.Delete("Server id", "Token");`
  * Ban
    * `Discord.REQ.UserServer.BanUser("user id", "guildid", "day", "token");`
  * Unban
    * `Discord.REQ.UserServer.UnBanUser("Userid", "guildid", "token");`
  * Kick user
    * `Discord.REQ.UserServer.KickUser("user id", "guild id", "token");`
  * Create role
    * `Discord.REQ.UserServer.CreateRole("guildid", "Token");`
  * Delete Role
    * `Discord.REQ.UserServer.DeleteRole("guild id", "roleid", "token");`
  * Set role name
    * `Discord.REQ.UserServer.SetRoleName("name", "guild id", "roleid", "token");`
  * Set role permissions
    * `Discord.REQ.UserServer.SetRolePermissions("Permissions number", "guild id", "role id", "token");`
  * Set role color
    * `Discord.REQ.UserServer.SetRoleColor("color number", "guildid", "role id", "Token");`
  * Set role mentionnable
    * `Discord.REQ.UserServer.SetRoleMentionable("guild id", "role id", "token");`
  * Set role unmentionnable
    * `Discord.REQ.UserServer.SetRoleUnMentionable("guild id", "role id", "Token");`

  
* Webhook 
  * Create Webhook
    * `Discord.REQ.Webhook.Create("Chan id", "token");`
  * Delete Webhook
    * `Discord.REQ.Webhook.Delete("Server id", "Token");`
* Group 
  * Rename group
    * `Discord.REQ.Group.Rename("groupid", "name", "token");`
  * Add user to a group
    * `Discord.REQ.Group.AddUser("groupid", "userid", "token");`
  * Kick from group
    * `Discord.REQ.Group.KickUser("GroupID", "userid" "token");`
  * Leave group
    * `Discord.REQ.Group.Leave("group id", "Token");`
* Nitro
  * Claim nitro
    * `Discord.REQ.Nitro.Claim("nitrocode", "token");`
  * Generate
    * `Discord.REQ.Nitro.GenerateRandomCode();`
  * Check nitro code
    * `Discord.REQ.Nitro.Check("NitroCode");`
