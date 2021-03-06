// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Properties of the shared file.</para>
    /// </summary>
    public class SharedFileMetadata
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedFileMetadata> Encoder = new SharedFileMetadataEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedFileMetadata> Decoder = new SharedFileMetadataDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFileMetadata" />
        /// class.</para>
        /// </summary>
        /// <param name="id">The ID of the file.</param>
        /// <param name="name">The name of this file.</param>
        /// <param name="policy">Policies governing this shared file.</param>
        /// <param name="previewUrl">URL for displaying a web preview of the shared
        /// file.</param>
        /// <param name="accessType">The current user's access level for this shared
        /// file.</param>
        /// <param name="expectedLinkMetadata">The expected metadata of the link associated for
        /// the file when it is first shared. Absent if the link already exists. This is for an
        /// unreleased feature so it may not be returned yet.</param>
        /// <param name="linkMetadata">The metadata of the link associated for the file. This
        /// is for an unreleased feature so it may not be returned yet.</param>
        /// <param name="ownerTeam">The team that owns the file. This field is not present if
        /// the file is not owned by a team.</param>
        /// <param name="parentSharedFolderId">The ID of the parent shared folder. This field
        /// is present only if the file is contained within a shared folder.</param>
        /// <param name="pathDisplay">The cased path to be used for display purposes only. In
        /// rare instances the casing will not correctly match the user's filesystem, but this
        /// behavior will match the path provided in the Core API v1. Absent for unmounted
        /// files.</param>
        /// <param name="pathLower">The lower-case full path of this file. Absent for unmounted
        /// files.</param>
        /// <param name="permissions">The sharing permissions that requesting user has on this
        /// file. This corresponds to the entries given in <see
        /// cref="Dropbox.Api.Sharing.GetFileMetadataBatchArg.Actions" /> or <see
        /// cref="Dropbox.Api.Sharing.GetFileMetadataArg.Actions" />.</param>
        /// <param name="timeInvited">Timestamp indicating when the current user was invited to
        /// this shared file. If the user was not invited to the shared file, the timestamp
        /// will indicate when the user was invited to the parent shared folder. This value may
        /// be absent.</param>
        public SharedFileMetadata(string id,
                                  string name,
                                  FolderPolicy policy,
                                  string previewUrl,
                                  AccessLevel accessType = null,
                                  ExpectedSharedContentLinkMetadata expectedLinkMetadata = null,
                                  SharedContentLinkMetadata linkMetadata = null,
                                  global::Dropbox.Api.Users.Team ownerTeam = null,
                                  string parentSharedFolderId = null,
                                  string pathDisplay = null,
                                  string pathLower = null,
                                  col.IEnumerable<FilePermission> permissions = null,
                                  sys.DateTime? timeInvited = null)
        {
            if (id == null)
            {
                throw new sys.ArgumentNullException("id");
            }
            if (id.Length < 1)
            {
                throw new sys.ArgumentOutOfRangeException("id", "Length should be at least 1");
            }
            if (!re.Regex.IsMatch(id, @"\A(?:id:.*)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("id", @"Value should match pattern '\A(?:id:.*)\z'");
            }

            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            if (policy == null)
            {
                throw new sys.ArgumentNullException("policy");
            }

            if (previewUrl == null)
            {
                throw new sys.ArgumentNullException("previewUrl");
            }

            if (parentSharedFolderId != null)
            {
                if (!re.Regex.IsMatch(parentSharedFolderId, @"\A(?:[-_0-9a-zA-Z:]+)\z"))
                {
                    throw new sys.ArgumentOutOfRangeException("parentSharedFolderId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z:]+)\z'");
                }
            }

            var permissionsList = enc.Util.ToList(permissions);

            this.Id = id;
            this.Name = name;
            this.Policy = policy;
            this.PreviewUrl = previewUrl;
            this.AccessType = accessType;
            this.ExpectedLinkMetadata = expectedLinkMetadata;
            this.LinkMetadata = linkMetadata;
            this.OwnerTeam = ownerTeam;
            this.ParentSharedFolderId = parentSharedFolderId;
            this.PathDisplay = pathDisplay;
            this.PathLower = pathLower;
            this.Permissions = permissionsList;
            this.TimeInvited = timeInvited;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFileMetadata" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedFileMetadata()
        {
        }

        /// <summary>
        /// <para>The ID of the file.</para>
        /// </summary>
        public string Id { get; protected set; }

        /// <summary>
        /// <para>The name of this file.</para>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// <para>Policies governing this shared file.</para>
        /// </summary>
        public FolderPolicy Policy { get; protected set; }

        /// <summary>
        /// <para>URL for displaying a web preview of the shared file.</para>
        /// </summary>
        public string PreviewUrl { get; protected set; }

        /// <summary>
        /// <para>The current user's access level for this shared file.</para>
        /// </summary>
        public AccessLevel AccessType { get; protected set; }

        /// <summary>
        /// <para>The expected metadata of the link associated for the file when it is first
        /// shared. Absent if the link already exists. This is for an unreleased feature so it
        /// may not be returned yet.</para>
        /// </summary>
        public ExpectedSharedContentLinkMetadata ExpectedLinkMetadata { get; protected set; }

        /// <summary>
        /// <para>The metadata of the link associated for the file. This is for an unreleased
        /// feature so it may not be returned yet.</para>
        /// </summary>
        public SharedContentLinkMetadata LinkMetadata { get; protected set; }

        /// <summary>
        /// <para>The team that owns the file. This field is not present if the file is not
        /// owned by a team.</para>
        /// </summary>
        public global::Dropbox.Api.Users.Team OwnerTeam { get; protected set; }

        /// <summary>
        /// <para>The ID of the parent shared folder. This field is present only if the file is
        /// contained within a shared folder.</para>
        /// </summary>
        public string ParentSharedFolderId { get; protected set; }

        /// <summary>
        /// <para>The cased path to be used for display purposes only. In rare instances the
        /// casing will not correctly match the user's filesystem, but this behavior will match
        /// the path provided in the Core API v1. Absent for unmounted files.</para>
        /// </summary>
        public string PathDisplay { get; protected set; }

        /// <summary>
        /// <para>The lower-case full path of this file. Absent for unmounted files.</para>
        /// </summary>
        public string PathLower { get; protected set; }

        /// <summary>
        /// <para>The sharing permissions that requesting user has on this file. This
        /// corresponds to the entries given in <see
        /// cref="Dropbox.Api.Sharing.GetFileMetadataBatchArg.Actions" /> or <see
        /// cref="Dropbox.Api.Sharing.GetFileMetadataArg.Actions" />.</para>
        /// </summary>
        public col.IList<FilePermission> Permissions { get; protected set; }

        /// <summary>
        /// <para>Timestamp indicating when the current user was invited to this shared file.
        /// If the user was not invited to the shared file, the timestamp will indicate when
        /// the user was invited to the parent shared folder. This value may be absent.</para>
        /// </summary>
        public sys.DateTime? TimeInvited { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedFileMetadata" />.</para>
        /// </summary>
        private class SharedFileMetadataEncoder : enc.StructEncoder<SharedFileMetadata>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedFileMetadata value, enc.IJsonWriter writer)
            {
                WriteProperty("id", value.Id, writer, enc.StringEncoder.Instance);
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                WriteProperty("policy", value.Policy, writer, global::Dropbox.Api.Sharing.FolderPolicy.Encoder);
                WriteProperty("preview_url", value.PreviewUrl, writer, enc.StringEncoder.Instance);
                if (value.AccessType != null)
                {
                    WriteProperty("access_type", value.AccessType, writer, global::Dropbox.Api.Sharing.AccessLevel.Encoder);
                }
                if (value.ExpectedLinkMetadata != null)
                {
                    WriteProperty("expected_link_metadata", value.ExpectedLinkMetadata, writer, global::Dropbox.Api.Sharing.ExpectedSharedContentLinkMetadata.Encoder);
                }
                if (value.LinkMetadata != null)
                {
                    WriteProperty("link_metadata", value.LinkMetadata, writer, global::Dropbox.Api.Sharing.SharedContentLinkMetadata.Encoder);
                }
                if (value.OwnerTeam != null)
                {
                    WriteProperty("owner_team", value.OwnerTeam, writer, global::Dropbox.Api.Users.Team.Encoder);
                }
                if (value.ParentSharedFolderId != null)
                {
                    WriteProperty("parent_shared_folder_id", value.ParentSharedFolderId, writer, enc.StringEncoder.Instance);
                }
                if (value.PathDisplay != null)
                {
                    WriteProperty("path_display", value.PathDisplay, writer, enc.StringEncoder.Instance);
                }
                if (value.PathLower != null)
                {
                    WriteProperty("path_lower", value.PathLower, writer, enc.StringEncoder.Instance);
                }
                if (value.Permissions.Count > 0)
                {
                    WriteListProperty("permissions", value.Permissions, writer, global::Dropbox.Api.Sharing.FilePermission.Encoder);
                }
                if (value.TimeInvited != null)
                {
                    WriteProperty("time_invited", value.TimeInvited.Value, writer, enc.DateTimeEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedFileMetadata" />.</para>
        /// </summary>
        private class SharedFileMetadataDecoder : enc.StructDecoder<SharedFileMetadata>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedFileMetadata" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedFileMetadata Create()
            {
                return new SharedFileMetadata();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedFileMetadata value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "id":
                        value.Id = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "policy":
                        value.Policy = global::Dropbox.Api.Sharing.FolderPolicy.Decoder.Decode(reader);
                        break;
                    case "preview_url":
                        value.PreviewUrl = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "access_type":
                        value.AccessType = global::Dropbox.Api.Sharing.AccessLevel.Decoder.Decode(reader);
                        break;
                    case "expected_link_metadata":
                        value.ExpectedLinkMetadata = global::Dropbox.Api.Sharing.ExpectedSharedContentLinkMetadata.Decoder.Decode(reader);
                        break;
                    case "link_metadata":
                        value.LinkMetadata = global::Dropbox.Api.Sharing.SharedContentLinkMetadata.Decoder.Decode(reader);
                        break;
                    case "owner_team":
                        value.OwnerTeam = global::Dropbox.Api.Users.Team.Decoder.Decode(reader);
                        break;
                    case "parent_shared_folder_id":
                        value.ParentSharedFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "path_display":
                        value.PathDisplay = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "path_lower":
                        value.PathLower = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "permissions":
                        value.Permissions = ReadList<FilePermission>(reader, global::Dropbox.Api.Sharing.FilePermission.Decoder);
                        break;
                    case "time_invited":
                        value.TimeInvited = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
