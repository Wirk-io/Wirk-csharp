/* 
 * Wirk
 *
 * API for api.wirk.io
 *
 * OpenAPI spec version: 1.0.0
 * 
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
    /// Model for TaskReaderServiceModel
    /// </summary>
    [DataContract]
    public partial class TaskReaderServiceModel :  IEquatable<TaskReaderServiceModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskReaderServiceModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskReaderServiceModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskReaderServiceModel" /> class.
        /// </summary>
        /// <param name="IdTask">IdTask (required).</param>
        /// <param name="Outputs">Outputs.</param>
        /// <param name="UpdateDate">UpdateDate.</param>
        public TaskReaderServiceModel(int? IdTask = null, Outputs Outputs = null, DateTime? UpdateDate = null)
        {
            // to ensure "IdTask" is required (not null)
            if (IdTask == null)
            {
                throw new InvalidDataException("IdTask is a required property for TaskReaderServiceModel and cannot be null");
            }
            else
            {
                this.IdTask = IdTask;
            }
            this.Outputs = Outputs;
            this.UpdateDate = UpdateDate;
        }
        
        /// <summary>
        /// Gets or Sets IdTask
        /// </summary>
        [DataMember(Name="IdTask", EmitDefaultValue=false)]
        public int? IdTask { get; set; }
        /// <summary>
        /// Gets or Sets Outputs
        /// </summary>
        [DataMember(Name="Outputs", EmitDefaultValue=false)]
        public Outputs Outputs { get; set; }
        /// <summary>
        /// Gets or Sets UpdateDate
        /// </summary>
        [DataMember(Name="UpdateDate", EmitDefaultValue=false)]
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskReaderServiceModel {\n");
            sb.Append("  IdTask: ").Append(IdTask).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  UpdateDate: ").Append(UpdateDate).Append("\n");
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
            return this.Equals(obj as TaskReaderServiceModel);
        }

        /// <summary>
        /// Returns true if TaskReaderServiceModel instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskReaderServiceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskReaderServiceModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTask == other.IdTask ||
                    this.IdTask != null &&
                    this.IdTask.Equals(other.IdTask)
                ) && 
                (
                    this.Outputs == other.Outputs ||
                    this.Outputs != null &&
                    this.Outputs.Equals(other.Outputs)
                ) && 
                (
                    this.UpdateDate == other.UpdateDate ||
                    this.UpdateDate != null &&
                    this.UpdateDate.Equals(other.UpdateDate)
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
                if (this.IdTask != null)
                    hash = hash * 59 + this.IdTask.GetHashCode();
                if (this.Outputs != null)
                    hash = hash * 59 + this.Outputs.GetHashCode();
                if (this.UpdateDate != null)
                    hash = hash * 59 + this.UpdateDate.GetHashCode();
                return hash;
            }
        }
    }

}