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
    /// Model for AppProject
    /// </summary>
    [DataContract]
    public partial class AppProjectWriterServiceModel :  IEquatable<AppProjectWriterServiceModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppProjectWriterServiceModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppProjectWriterServiceModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppProjectWriterServiceModel" /> class.
        /// </summary>
        /// <param name="IdApp">IdApp (required).</param>
        /// <param name="IdQuality">IdQuality.</param>
        /// <param name="Instruction">Instruction.</param>
        /// <param name="QuestionOptions">QuestionOptions.</param>
        /// <param name="Title">Title.</param>
        /// <param name="UrlNotification">UrlNotification.</param>
        public AppProjectWriterServiceModel(int? IdApp = null, int? IdQuality = null, string Instruction = null, List<string> QuestionOptions = null, string Title = null, string UrlNotification = null)
        {
            // to ensure "IdApp" is required (not null)
            if (IdApp == null)
            {
                throw new InvalidDataException("IdApp is a required property for AppProjectWriterServiceModel and cannot be null");
            }
            else
            {
                this.IdApp = IdApp;
            }
            this.IdQuality = IdQuality;
            this.Instruction = Instruction;
            this.QuestionOptions = QuestionOptions;
            this.Title = Title;
            this.UrlNotification = UrlNotification;
        }
        
        /// <summary>
        /// Gets or Sets IdApp
        /// </summary>
        [DataMember(Name="IdApp", EmitDefaultValue=false)]
        public int? IdApp { get; set; }
        /// <summary>
        /// Gets or Sets IdQuality
        /// </summary>
        [DataMember(Name="IdQuality", EmitDefaultValue=false)]
        public int? IdQuality { get; set; }
        /// <summary>
        /// Gets or Sets Instruction
        /// </summary>
        [DataMember(Name="Instruction", EmitDefaultValue=false)]
        public string Instruction { get; set; }
        /// <summary>
        /// Gets or Sets QuestionOptions
        /// </summary>
        [DataMember(Name="QuestionOptions", EmitDefaultValue=false)]
        public List<string> QuestionOptions { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets UrlNotification
        /// </summary>
        [DataMember(Name="UrlNotification", EmitDefaultValue=false)]
        public string UrlNotification { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppProjectWriterServiceModel {\n");
            sb.Append("  IdApp: ").Append(IdApp).Append("\n");
            sb.Append("  IdQuality: ").Append(IdQuality).Append("\n");
            sb.Append("  Instruction: ").Append(Instruction).Append("\n");
            sb.Append("  QuestionOptions: ").Append(QuestionOptions).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UrlNotification: ").Append(UrlNotification).Append("\n");
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
            return this.Equals(obj as AppProjectWriterServiceModel);
        }

        /// <summary>
        /// Returns true if AppProjectWriterServiceModel instances are equal
        /// </summary>
        /// <param name="other">Instance of AppProjectWriterServiceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppProjectWriterServiceModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdApp == other.IdApp ||
                    this.IdApp != null &&
                    this.IdApp.Equals(other.IdApp)
                ) && 
                (
                    this.IdQuality == other.IdQuality ||
                    this.IdQuality != null &&
                    this.IdQuality.Equals(other.IdQuality)
                ) && 
                (
                    this.Instruction == other.Instruction ||
                    this.Instruction != null &&
                    this.Instruction.Equals(other.Instruction)
                ) && 
                (
                    this.QuestionOptions == other.QuestionOptions ||
                    this.QuestionOptions != null &&
                    this.QuestionOptions.SequenceEqual(other.QuestionOptions)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.UrlNotification == other.UrlNotification ||
                    this.UrlNotification != null &&
                    this.UrlNotification.Equals(other.UrlNotification)
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
                if (this.IdApp != null)
                    hash = hash * 59 + this.IdApp.GetHashCode();
                if (this.IdQuality != null)
                    hash = hash * 59 + this.IdQuality.GetHashCode();
                if (this.Instruction != null)
                    hash = hash * 59 + this.Instruction.GetHashCode();
                if (this.QuestionOptions != null)
                    hash = hash * 59 + this.QuestionOptions.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.UrlNotification != null)
                    hash = hash * 59 + this.UrlNotification.GetHashCode();
                return hash;
            }
        }
    }

}
