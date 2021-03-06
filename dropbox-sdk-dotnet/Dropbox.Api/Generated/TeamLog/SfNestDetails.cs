// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Changed parent of shared folder.</para>
    /// </summary>
    public class SfNestDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SfNestDetails> Encoder = new SfNestDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SfNestDetails> Decoder = new SfNestDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SfNestDetails" /> class.</para>
        /// </summary>
        /// <param name="targetIndex">Target asset index.</param>
        /// <param name="originalFolderName">Original shared folder name.</param>
        /// <param name="prevParentNsId">Previous parent namespace ID. Might be missing due to
        /// historical data gap.</param>
        /// <param name="newParentNsId">New parent namespace ID. Might be missing due to
        /// historical data gap.</param>
        public SfNestDetails(long targetIndex,
                             string originalFolderName,
                             string prevParentNsId = null,
                             string newParentNsId = null)
        {
            if (originalFolderName == null)
            {
                throw new sys.ArgumentNullException("originalFolderName");
            }

            if (prevParentNsId != null)
            {
                if (!re.Regex.IsMatch(prevParentNsId, @"\A(?:[-_0-9a-zA-Z:]+)\z"))
                {
                    throw new sys.ArgumentOutOfRangeException("prevParentNsId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z:]+)\z'");
                }
            }

            if (newParentNsId != null)
            {
                if (!re.Regex.IsMatch(newParentNsId, @"\A(?:[-_0-9a-zA-Z:]+)\z"))
                {
                    throw new sys.ArgumentOutOfRangeException("newParentNsId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z:]+)\z'");
                }
            }

            this.TargetIndex = targetIndex;
            this.OriginalFolderName = originalFolderName;
            this.PrevParentNsId = prevParentNsId;
            this.NewParentNsId = newParentNsId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SfNestDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SfNestDetails()
        {
        }

        /// <summary>
        /// <para>Target asset index.</para>
        /// </summary>
        public long TargetIndex { get; protected set; }

        /// <summary>
        /// <para>Original shared folder name.</para>
        /// </summary>
        public string OriginalFolderName { get; protected set; }

        /// <summary>
        /// <para>Previous parent namespace ID. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public string PrevParentNsId { get; protected set; }

        /// <summary>
        /// <para>New parent namespace ID. Might be missing due to historical data gap.</para>
        /// </summary>
        public string NewParentNsId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SfNestDetails" />.</para>
        /// </summary>
        private class SfNestDetailsEncoder : enc.StructEncoder<SfNestDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SfNestDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("target_index", value.TargetIndex, writer, enc.Int64Encoder.Instance);
                WriteProperty("original_folder_name", value.OriginalFolderName, writer, enc.StringEncoder.Instance);
                if (value.PrevParentNsId != null)
                {
                    WriteProperty("prev_parent_ns_id", value.PrevParentNsId, writer, enc.StringEncoder.Instance);
                }
                if (value.NewParentNsId != null)
                {
                    WriteProperty("new_parent_ns_id", value.NewParentNsId, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SfNestDetails" />.</para>
        /// </summary>
        private class SfNestDetailsDecoder : enc.StructDecoder<SfNestDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SfNestDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SfNestDetails Create()
            {
                return new SfNestDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SfNestDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "target_index":
                        value.TargetIndex = enc.Int64Decoder.Instance.Decode(reader);
                        break;
                    case "original_folder_name":
                        value.OriginalFolderName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "prev_parent_ns_id":
                        value.PrevParentNsId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "new_parent_ns_id":
                        value.NewParentNsId = enc.StringDecoder.Instance.Decode(reader);
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
