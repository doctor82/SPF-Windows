﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/teamData.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/teamData.xsd", IsNullable=false)]
public partial class LeagueTeam {
    
    private string teamNameField;
    
    private string headCoachField;
    
    private string mainColorField;
    
    private string secondColorField;
    
    private LeagueTeamTeamRecord teamRecordField;
    
    /// <remarks/>
    public string teamName {
        get {
            return this.teamNameField;
        }
        set {
            this.teamNameField = value;
        }
    }
    
    /// <remarks/>
    public string headCoach {
        get {
            return this.headCoachField;
        }
        set {
            this.headCoachField = value;
        }
    }
    
    /// <remarks/>
    public string mainColor {
        get {
            return this.mainColorField;
        }
        set {
            this.mainColorField = value;
        }
    }
    
    /// <remarks/>
    public string secondColor {
        get {
            return this.secondColorField;
        }
        set {
            this.secondColorField = value;
        }
    }
    
    /// <remarks/>
    public LeagueTeamTeamRecord teamRecord {
        get {
            return this.teamRecordField;
        }
        set {
            this.teamRecordField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/teamData.xsd")]
public partial class LeagueTeamTeamRecord {
    
    private int winsField;
    
    private int lossField;
    
    private int tiesField;
    
    /// <remarks/>
    public int Wins {
        get {
            return this.winsField;
        }
        set {
            this.winsField = value;
        }
    }
    
    /// <remarks/>
    public int Loss {
        get {
            return this.lossField;
        }
        set {
            this.lossField = value;
        }
    }
    
    /// <remarks/>
    public int Ties {
        get {
            return this.tiesField;
        }
        set {
            this.tiesField = value;
        }
    }
}