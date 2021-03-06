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
    /// Model for TaskLineReaderServiceModel
    /// </summary>
    [DataContract]
    public partial class TaskLineReaderServiceModel :  IEquatable<TaskLineReaderServiceModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskLineReaderServiceModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskLineReaderServiceModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskLineReaderServiceModel" /> class.
        /// </summary>
        /// <param name="IdAppProject">IdAppProject (required).</param>
        /// <param name="IdTaskLine">IdTaskLine.</param>
        /// <param name="Inputs">Inputs.</param>
        /// <param name="Tasks">Tasks.</param>
        public TaskLineReaderServiceModel(int? IdAppProject = null, int? IdTaskLine = null, List<string> Inputs = null, List<TaskReaderServiceModel> Tasks = null)
        {
            // to ensure "IdAppProject" is required (not null)
            if (IdAppProject == null)
            {
                throw new InvalidDataException("IdAppProject is a required property for TaskLineReaderServiceModel and cannot be null");
            }
            else
            {
                this.IdAppProject = IdAppProject;
            }
            this.IdTaskLine = IdTaskLine;
            this.Inputs = Inputs;
            this.Tasks = Tasks;
        }
        
        /// <summary>
        /// Gets or Sets IdAppProject
        /// </summary>
        [DataMember(Name="IdAppProject", EmitDefaultValue=false)]
        public int? IdAppProject { get; set; }
        /// <summary>
        /// Gets or Sets IdTaskLine
        /// </summary>
        [DataMember(Name="IdTaskLine", EmitDefaultValue=false)]
        public int? IdTaskLine { get; set; }
        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name="Inputs", EmitDefaultValue=false)]
        public List<string> Inputs { get; set; }
        /// <summary>
        /// Gets or Sets Tasks
        /// </summary>
        [DataMember(Name="Tasks", EmitDefaultValue=false)]
        public List<TaskReaderServiceModel> Tasks { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskLineReaderServiceModel {\n");
            sb.Append("  IdAppProject: ").Append(IdAppProject).Append("\n");
            sb.Append("  IdTaskLine: ").Append(IdTaskLine).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
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
            return this.Equals(obj as TaskLineReaderServiceModel);
        }

        /// <summary>
        /// Returns true if TaskLineReaderServiceModel instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskLineReaderServiceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskLineReaderServiceModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdAppProject == other.IdAppProject ||
                    this.IdAppProject != null &&
                    this.IdAppProject.Equals(other.IdAppProject)
                ) && 
                (
                    this.IdTaskLine == other.IdTaskLine ||
                    this.IdTaskLine != null &&
                    this.IdTaskLine.Equals(other.IdTaskLine)
                ) && 
                (
                    this.Inputs == other.Inputs ||
                    this.Inputs != null &&
                    this.Inputs.SequenceEqual(other.Inputs)
                ) && 
                (
                    this.Tasks == other.Tasks ||
                    this.Tasks != null &&
                    this.Tasks.SequenceEqual(other.Tasks)
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
                if (this.IdAppProject != null)
                    hash = hash * 59 + this.IdAppProject.GetHashCode();
                if (this.IdTaskLine != null)
                    hash = hash * 59 + this.IdTaskLine.GetHashCode();
                if (this.Inputs != null)
                    hash = hash * 59 + this.Inputs.GetHashCode();
                if (this.Tasks != null)
                    hash = hash * 59 + this.Tasks.GetHashCode();
                return hash;
            }
        }
    }

}
