/* 
 * Wirk
 *
 * <p>API for api.wirk.io</p> 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: contact@wirk.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Io.Wirk.Api.Wirk.Model
{
    /// <summary>
    /// Model for Quality
    /// </summary>
    [DataContract]
    public partial class QualityReaderServiceModel :  IEquatable<QualityReaderServiceModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReaderServiceModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QualityReaderServiceModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReaderServiceModel" /> class.
        /// </summary>
        /// <param name="Credit">Credit (required).</param>
        /// <param name="IdQuality">IdQuality.</param>
        /// <param name="Name">Name.</param>
        public QualityReaderServiceModel(int? Credit = null, int? IdQuality = null, string Name = null)
        {
            // to ensure "Credit" is required (not null)
            if (Credit == null)
            {
                throw new InvalidDataException("Credit is a required property for QualityReaderServiceModel and cannot be null");
            }
            else
            {
                this.Credit = Credit;
            }
            this.IdQuality = IdQuality;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets Credit
        /// </summary>
        [DataMember(Name="Credit", EmitDefaultValue=false)]
        public int? Credit { get; set; }
        /// <summary>
        /// Gets or Sets IdQuality
        /// </summary>
        [DataMember(Name="IdQuality", EmitDefaultValue=false)]
        public int? IdQuality { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualityReaderServiceModel {\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  IdQuality: ").Append(IdQuality).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as QualityReaderServiceModel);
        }

        /// <summary>
        /// Returns true if QualityReaderServiceModel instances are equal
        /// </summary>
        /// <param name="other">Instance of QualityReaderServiceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QualityReaderServiceModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Credit == other.Credit ||
                    this.Credit != null &&
                    this.Credit.Equals(other.Credit)
                ) && 
                (
                    this.IdQuality == other.IdQuality ||
                    this.IdQuality != null &&
                    this.IdQuality.Equals(other.IdQuality)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Credit != null)
                    hash = hash * 59 + this.Credit.GetHashCode();
                if (this.IdQuality != null)
                    hash = hash * 59 + this.IdQuality.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }
    }

}
