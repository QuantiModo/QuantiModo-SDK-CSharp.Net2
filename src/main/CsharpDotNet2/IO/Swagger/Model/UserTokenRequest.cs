using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserTokenRequest {
    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public UserTokenRequestInnerUserField User { get; set; }

    /// <summary>
    /// Organization Access token
    /// </summary>
    /// <value>Organization Access token</value>
    [DataMember(Name="organizationAccessToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organizationAccessToken")]
    public string OrganizationAccessToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserTokenRequest {\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  OrganizationAccessToken: ").Append(OrganizationAccessToken).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
