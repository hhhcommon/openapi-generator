/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ShapeInterface
    /// </summary>
    [DataContract(Name="ShapeInterface")]
    public partial class ShapeInterface : IEquatable<ShapeInterface>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeInterface" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShapeInterface() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeInterface" /> class.
        /// </summary>
        /// <param name="shapeType">shapeType (required).</param>
        public ShapeInterface(string shapeType = default(string))
        {
            // to ensure "shapeType" is required (not null)
            this.ShapeType = shapeType ?? throw new ArgumentNullException("shapeType is a required property for ShapeInterface and cannot be null");
        }

        /// <summary>
        /// Gets or Sets ShapeType
        /// </summary>
        [DataMember(Name = "shapeType", EmitDefaultValue = false)]
        public string ShapeType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShapeInterface {\n");
            sb.Append("  ShapeType: ").Append(ShapeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as ShapeInterface).AreEqual;
        }

        /// <summary>
        /// Returns true if ShapeInterface instances are equal
        /// </summary>
        /// <param name="input">Instance of ShapeInterface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShapeInterface input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ShapeType != null)
                    hashCode = hashCode * 59 + this.ShapeType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
