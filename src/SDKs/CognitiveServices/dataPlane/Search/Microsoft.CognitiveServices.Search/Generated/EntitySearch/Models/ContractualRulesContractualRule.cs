// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Search.EntitySearch.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Search;
    using Microsoft.CognitiveServices.Search.EntitySearch;
    using Newtonsoft.Json;
    using System.Linq;

    [Newtonsoft.Json.JsonObject("ContractualRules/ContractualRule")]
    public partial class ContractualRulesContractualRule
    {
        /// <summary>
        /// Initializes a new instance of the ContractualRulesContractualRule
        /// class.
        /// </summary>
        public ContractualRulesContractualRule()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContractualRulesContractualRule
        /// class.
        /// </summary>
        /// <param name="targetPropertyName">The name of the field that the
        /// rule applies to.</param>
        public ContractualRulesContractualRule(string targetPropertyName = default(string))
        {
            TargetPropertyName = targetPropertyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the field that the rule applies to.
        /// </summary>
        [JsonProperty(PropertyName = "targetPropertyName")]
        public string TargetPropertyName { get; private set; }

    }
}
