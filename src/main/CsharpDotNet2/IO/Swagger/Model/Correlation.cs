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
  public class Correlation {
    
    /// <summary>
    /// id
    /// </summary>
    /// <value>id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    
    /// <summary>
    /// Time at which correlation was calculated
    /// </summary>
    /// <value>Time at which correlation was calculated</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public int? Timestamp { get; set; }

    
    /// <summary>
    /// ID of user that owns this correlation
    /// </summary>
    /// <value>ID of user that owns this correlation</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    
    /// <summary>
    /// Pearson correlation coefficient between cause and effect measurements
    /// </summary>
    /// <value>Pearson correlation coefficient between cause and effect measurements</value>
    [DataMember(Name="correlation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "correlation")]
    public float? Correlation { get; set; }

    
    /// <summary>
    /// variable ID of the cause variable for which the user desires correlations
    /// </summary>
    /// <value>variable ID of the cause variable for which the user desires correlations</value>
    [DataMember(Name="cause_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause_id")]
    public int? CauseId { get; set; }

    
    /// <summary>
    /// variable ID of the effect variable for which the user desires correlations
    /// </summary>
    /// <value>variable ID of the effect variable for which the user desires correlations</value>
    [DataMember(Name="effect_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effect_id")]
    public int? EffectId { get; set; }

    
    /// <summary>
    /// User estimated or default time after cause measurement before a perceivable effect is observed
    /// </summary>
    /// <value>User estimated or default time after cause measurement before a perceivable effect is observed</value>
    [DataMember(Name="onset_delay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "onset_delay")]
    public int? OnsetDelay { get; set; }

    
    /// <summary>
    /// Time over which the cause is expected to produce a perceivable effect following the onset delay
    /// </summary>
    /// <value>Time over which the cause is expected to produce a perceivable effect following the onset delay</value>
    [DataMember(Name="duration_of_action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration_of_action")]
    public int? DurationOfAction { get; set; }

    
    /// <summary>
    /// Number of points that went into the correlation calculation
    /// </summary>
    /// <value>Number of points that went into the correlation calculation</value>
    [DataMember(Name="number_of_pairs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_pairs")]
    public int? NumberOfPairs { get; set; }

    
    /// <summary>
    /// cause value that predicts an above average effect value (in default unit for cause variable)
    /// </summary>
    /// <value>cause value that predicts an above average effect value (in default unit for cause variable)</value>
    [DataMember(Name="value_predicting_high_outcome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value_predicting_high_outcome")]
    public float? ValuePredictingHighOutcome { get; set; }

    
    /// <summary>
    /// cause value that predicts a below average effect value (in default unit for cause variable)
    /// </summary>
    /// <value>cause value that predicts a below average effect value (in default unit for cause variable)</value>
    [DataMember(Name="value_predicting_low_outcome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value_predicting_low_outcome")]
    public float? ValuePredictingLowOutcome { get; set; }

    
    /// <summary>
    /// Optimal Pearson Product
    /// </summary>
    /// <value>Optimal Pearson Product</value>
    [DataMember(Name="optimal_pearson_product", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optimal_pearson_product")]
    public float? OptimalPearsonProduct { get; set; }

    
    /// <summary>
    /// Vote
    /// </summary>
    /// <value>Vote</value>
    [DataMember(Name="vote", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vote")]
    public float? Vote { get; set; }

    
    /// <summary>
    /// A function of the effect size and sample size
    /// </summary>
    /// <value>A function of the effect size and sample size</value>
    [DataMember(Name="statistical_significance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statistical_significance")]
    public float? StatisticalSignificance { get; set; }

    
    /// <summary>
    /// Unit of Cause
    /// </summary>
    /// <value>Unit of Cause</value>
    [DataMember(Name="cause_unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause_unit")]
    public string CauseUnit { get; set; }

    
    /// <summary>
    /// Unit ID of Cause
    /// </summary>
    /// <value>Unit ID of Cause</value>
    [DataMember(Name="cause_unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause_unit_id")]
    public int? CauseUnitId { get; set; }

    
    /// <summary>
    /// Cause changes
    /// </summary>
    /// <value>Cause changes</value>
    [DataMember(Name="cause_changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause_changes")]
    public int? CauseChanges { get; set; }

    
    /// <summary>
    /// Effect changes
    /// </summary>
    /// <value>Effect changes</value>
    [DataMember(Name="effect_changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effect_changes")]
    public int? EffectChanges { get; set; }

    
    /// <summary>
    /// QM Score
    /// </summary>
    /// <value>QM Score</value>
    [DataMember(Name="qm_score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qm_score")]
    public float? QmScore { get; set; }

    
    /// <summary>
    /// error
    /// </summary>
    /// <value>error</value>
    [DataMember(Name="error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error")]
    public string Error { get; set; }

    
    /// <summary>
    /// created_at
    /// </summary>
    /// <value>created_at</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    
    /// <summary>
    /// updated_at
    /// </summary>
    /// <value>updated_at</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    
    /// <summary>
    /// Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation
    /// </summary>
    /// <value>Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</value>
    [DataMember(Name="reverse_pearson_correlation_coefficient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reverse_pearson_correlation_coefficient")]
    public float? ReversePearsonCorrelationCoefficient { get; set; }

    
    /// <summary>
    /// Predictive Pearson Correlation Coefficient
    /// </summary>
    /// <value>Predictive Pearson Correlation Coefficient</value>
    [DataMember(Name="predictive_pearson_correlation_coefficient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "predictive_pearson_correlation_coefficient")]
    public float? PredictivePearsonCorrelationCoefficient { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Correlation {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      
      sb.Append("  Correlation: ").Append(Correlation).Append("\n");
      
      sb.Append("  CauseId: ").Append(CauseId).Append("\n");
      
      sb.Append("  EffectId: ").Append(EffectId).Append("\n");
      
      sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
      
      sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
      
      sb.Append("  NumberOfPairs: ").Append(NumberOfPairs).Append("\n");
      
      sb.Append("  ValuePredictingHighOutcome: ").Append(ValuePredictingHighOutcome).Append("\n");
      
      sb.Append("  ValuePredictingLowOutcome: ").Append(ValuePredictingLowOutcome).Append("\n");
      
      sb.Append("  OptimalPearsonProduct: ").Append(OptimalPearsonProduct).Append("\n");
      
      sb.Append("  Vote: ").Append(Vote).Append("\n");
      
      sb.Append("  StatisticalSignificance: ").Append(StatisticalSignificance).Append("\n");
      
      sb.Append("  CauseUnit: ").Append(CauseUnit).Append("\n");
      
      sb.Append("  CauseUnitId: ").Append(CauseUnitId).Append("\n");
      
      sb.Append("  CauseChanges: ").Append(CauseChanges).Append("\n");
      
      sb.Append("  EffectChanges: ").Append(EffectChanges).Append("\n");
      
      sb.Append("  QmScore: ").Append(QmScore).Append("\n");
      
      sb.Append("  Error: ").Append(Error).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      
      sb.Append("  ReversePearsonCorrelationCoefficient: ").Append(ReversePearsonCorrelationCoefficient).Append("\n");
      
      sb.Append("  PredictivePearsonCorrelationCoefficient: ").Append(PredictivePearsonCorrelationCoefficient).Append("\n");
      
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
