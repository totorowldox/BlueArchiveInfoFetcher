using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueArchiveInfoFetcher.Serialized
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Comment
    {
        public string content { get; set; }
        public int created_at { get; set; }
        public string last_ip_area { get; set; }
        public int source { get; set; }
        public User user { get; set; }
    }

    public class CustomTag
    {
        public string tag_color { get; set; }
        public string tag_name { get; set; }
    }

    public class Datum
    {
        public Module module { get; set; }
        public List<List> list { get; set; }
    }

    public class Game
    {
        public string alias { get; set; }
        public int content_count { get; set; }
        public int follow_count { get; set; }
        public string icon { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }

    public class List
    {
        public int created_at { get; set; }
        public string desc { get; set; }
        public int game_id { get; set; }
        public int id { get; set; }
        public int is_app { get; set; }
        public string jump_url { get; set; }
        public int sort { get; set; }
        public string thumb { get; set; }
        public int uid { get; set; }
        public int updated_at { get; set; }
        public string apple_uid { get; set; }
        public int? audit_uid { get; set; }
        public string avatar { get; set; }
        public CustomTag custom_tag { get; set; }
        public string description { get; set; }
        public int? follow_num { get; set; }
        public int? is_super { get; set; }
        public string last_ip_area { get; set; }
        public int? last_login_at { get; set; }
        public int? last_login_device_num { get; set; }
        public string phone { get; set; }
        public string qq_openid { get; set; }
        public string qq_unionid { get; set; }
        public int? role_id { get; set; }
        public string sdk_token { get; set; }
        public int? state { get; set; }
        public int? status { get; set; }
        public int? subscribe_num { get; set; }
        public int? update_avatar_at { get; set; }
        public string username { get; set; }
        public string wechat_openid { get; set; }
        public string wechat_unionid { get; set; }
        public List<Comment> comment { get; set; }
        public int? comment_at { get; set; }
        public int? comment_count { get; set; }
        public int? content_type { get; set; }
        public int? del_at { get; set; }
        public int? del_uid { get; set; }
        public int? entry_id { get; set; }
        public int? favorite_count { get; set; }
        public Game game { get; set; }
        public string game_alias { get; set; }
        public int? is_del { get; set; }
        public int? is_like { get; set; }
        public int? is_only { get; set; }
        public int? is_prohibit_reply { get; set; }
        public int? is_release { get; set; }
        public int? is_top { get; set; }
        public int? last_at { get; set; }
        public int? like_count { get; set; }
        public string model_ids { get; set; }
        public int? source { get; set; }
        public string summary { get; set; }
        public string tag { get; set; }
        public object themes { get; set; }
        public string title { get; set; }
        public int? type { get; set; }
        public int? unlike_count { get; set; }
        public UpdateUser update_user { get; set; }
        public int? updated_uid { get; set; }
        public User user { get; set; }
        public int? view_count { get; set; }
        public string icon { get; set; }
        public string link { get; set; }
        public long? begin_at { get; set; }
        public int? count_down { get; set; }
        public int? creator_uid { get; set; }
        public long? end_at { get; set; }
        public int? importance { get; set; }
        public string link_url { get; set; }
        public string picture { get; set; }
        public string pub_area { get; set; }
    }

    public class Meta
    {
        public string request_id { get; set; }
        public string trace_id { get; set; }
    }

    public class Module
    {
        public int id { get; set; }
        public int game_id { get; set; }
        public string name { get; set; }
        public int status { get; set; }
        public int type { get; set; }
        public int sort { get; set; }
        public int land_sort { get; set; }
        public int updated_uid { get; set; }
        public int updated_at { get; set; }
    }

    public class IndexData
    {
        public int code { get; set; }
        public string msg { get; set; }
        public List<Datum> data { get; set; }
        public Meta meta { get; set; }
    }

    public class Tag
    {
        public int id { get; set; }
        public string image { get; set; }
        public int level { get; set; }
        public string name { get; set; }
        public int sort { get; set; }
        public int tag_id { get; set; }
        public int uid { get; set; }
    }

    public class UpdateUser
    {
        public string avatar { get; set; }
        public CustomTag custom_tag { get; set; }
        public string description { get; set; }
        public int follow_num { get; set; }
        public int role_id { get; set; }
        public object tags { get; set; }
        public int uid { get; set; }
        public string username { get; set; }
    }

    public class User
    {
        public string avatar { get; set; }
        public int uid { get; set; }
        public string username { get; set; }
        public CustomTag custom_tag { get; set; }
        public string description { get; set; }
        public int follow_num { get; set; }
        public int role_id { get; set; }
        public List<Tag> tags { get; set; }
    }


}
