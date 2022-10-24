using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace SpeckleBot.SpeckleModels
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum EventType
    {
        [EnumMember(Value = "stream_update")]
        StreamUpdate,
        [EnumMember(Value = "stream_delete")]
        StreamDelete,
        [EnumMember(Value = "branch_create")]
        BranchCreate,
        [EnumMember(Value = "branch_update")]
        BranchUpdate,
        [EnumMember(Value = "branch_delete")]
        BranchDelete,
        [EnumMember(Value = "commit_create")]
        CommitCreate,
        [EnumMember(Value = "commit_update")]
        CommitUpdate,
        [EnumMember(Value = "commit_delete")]
        CommitDelete,
        [EnumMember(Value = "commit_receive")]
        CommitReceive,
        [EnumMember(Value = "comment_created")]
        CommentCreated,
        [EnumMember(Value = "comment_replied")]
        CommentReplied,
        [EnumMember(Value = "comment_archived")]
        CommentArchived,
        [EnumMember(Value = "stream_permissions_add")]
        StreamPermissionsAdd,
        [EnumMember(Value = "stream_permissions_remove")]
        StreamPermissionsRemove,
    }
}
