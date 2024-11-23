//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Friends.Internal.Generated.Http;



namespace Unity.Services.Friends.Internal.Generated.Models
{
    /// <summary>
    /// AddRelationshipRequest model
    /// </summary>
    [Preserve]
    [DataContract(Name = "AddRelationshipRequest")]
    internal class AddRelationshipRequest
    {
        /// <summary>
        /// Creates an instance of AddRelationshipRequest.
        /// </summary>
        /// <param name="type">type param</param>
        /// <param name="members">members param</param>
        [Preserve]
        public AddRelationshipRequest(RelationshipType type, List<MemberIdentity> members)
        {
            Type = type;
            Members = members;
        }

        /// <summary>
        /// Parameter type of AddRelationshipRequest
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public RelationshipType Type{ get; }
        
        /// <summary>
        /// Parameter members of AddRelationshipRequest
        /// </summary>
        [Preserve]
        [DataMember(Name = "members", IsRequired = true, EmitDefaultValue = true)]
        public List<MemberIdentity> Members{ get; }
    
        /// <summary>
        /// Formats a AddRelationshipRequest into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "type," + Type.ToString() + ",";
            if (Members != null)
            {
                serializedModel += "members," + Members.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a AddRelationshipRequest as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var typeStringValue = Type.ToString();
            dictionary.Add("type", typeStringValue);
            
            return dictionary;
        }
    }
}