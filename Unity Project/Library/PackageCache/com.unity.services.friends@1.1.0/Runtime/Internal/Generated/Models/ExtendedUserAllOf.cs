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
    /// ExtendedUserAllOf model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ExtendedUser_allOf")]
    internal class ExtendedUserAllOf
    {
        /// <summary>
        /// Creates an instance of ExtendedUserAllOf.
        /// </summary>
        /// <param name="presence">presence param</param>
        /// <param name="profile">profile param</param>
        [Preserve]
        public ExtendedUserAllOf(UserPresence presence = default, UserProfile profile = default)
        {
            Presence = presence;
            Profile = profile;
        }

        /// <summary>
        /// Parameter presence of ExtendedUserAllOf
        /// </summary>
        [Preserve]
        [DataMember(Name = "presence", EmitDefaultValue = false)]
        public UserPresence Presence{ get; }
        
        /// <summary>
        /// Parameter profile of ExtendedUserAllOf
        /// </summary>
        [Preserve]
        [DataMember(Name = "profile", EmitDefaultValue = false)]
        public UserProfile Profile{ get; }
    
        /// <summary>
        /// Formats a ExtendedUserAllOf into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Presence != null)
            {
                serializedModel += "presence," + Presence.ToString() + ",";
            }
            if (Profile != null)
            {
                serializedModel += "profile," + Profile.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a ExtendedUserAllOf as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            return dictionary;
        }
    }
}
