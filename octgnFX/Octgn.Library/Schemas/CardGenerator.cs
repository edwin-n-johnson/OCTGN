﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class templates
{

    private templatesBlock[] blocksField;

    private templatesTemplate[] templateField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("block", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public templatesBlock[] blocks
    {
        get
        {
            return this.blocksField;
        }
        set
        {
            this.blocksField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("template", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesTemplate[] template
    {
        get
        {
            return this.templateField;
        }
        set
        {
            this.templateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class templatesBlock
{

    private templatesBlockLocation locationField;

    private templatesBlockText textField;

    private templatesBlockBorder borderField;

    private templatesBlockWordwrap wordwrapField;

    private blocktype typeField;

    private string idField;

    private string srcField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesBlockLocation location
    {
        get
        {
            return this.locationField;
        }
        set
        {
            this.locationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesBlockText text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesBlockBorder border
    {
        get
        {
            return this.borderField;
        }
        set
        {
            this.borderField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesBlockWordwrap wordwrap
    {
        get
        {
            return this.wordwrapField;
        }
        set
        {
            this.wordwrapField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public blocktype type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string src
    {
        get
        {
            return this.srcField;
        }
        set
        {
            this.srcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class templatesBlockLocation
{

    private string xField;

    private string yField;

    private string rotateField;

    private proxyBoolean altrotateField;

    private proxyBoolean flipField;

    public templatesBlockLocation()
    {
        this.rotateField = "0";
        this.altrotateField = proxyBoolean.False;
        this.flipField = proxyBoolean.False;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    [System.ComponentModel.DefaultValueAttribute("0")]
    public string rotate
    {
        get
        {
            return this.rotateField;
        }
        set
        {
            this.rotateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(proxyBoolean.False)]
    public proxyBoolean altrotate
    {
        get
        {
            return this.altrotateField;
        }
        set
        {
            this.altrotateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(proxyBoolean.False)]
    public proxyBoolean flip
    {
        get
        {
            return this.flipField;
        }
        set
        {
            this.flipField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
public enum proxyBoolean
{

    /// <remarks/>
    True,

    /// <remarks/>
    False,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class artoverlay
{

    private artoverlayLocation locationField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public artoverlayLocation location
    {
        get
        {
            return this.locationField;
        }
        set
        {
            this.locationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class artoverlayLocation
{

    private string xField;

    private string yField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class link
{

    private linkProperty[] propertyField;

    private string blockField;

    private string separatorField;

    public link()
    {
        this.separatorField = " ";
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("property", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public linkProperty[] property
    {
        get
        {
            return this.propertyField;
        }
        set
        {
            this.propertyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(" ")]
    public string separator
    {
        get
        {
            return this.separatorField;
        }
        set
        {
            this.separatorField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class linkProperty
{

    private string nameField;

    private string formatField;

    public linkProperty()
    {
        this.formatField = "{}";
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("{}")]
    public string format
    {
        get
        {
            return this.formatField;
        }
        set
        {
            this.formatField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class conditional
{

    private object[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("else", typeof(conditionalElse), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("elseif", typeof(conditionalElseif), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("if", typeof(conditionalIF), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("switch", typeof(conditionalSwitch), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class conditionalElse
{

    private link[] linkField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public link[] link
    {
        get
        {
            return this.linkField;
        }
        set
        {
            this.linkField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class conditionalElseif
{

    private link[] linkField;

    private string propertyField;

    private string valueField;

    private string containsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public link[] link
    {
        get
        {
            return this.linkField;
        }
        set
        {
            this.linkField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string property
    {
        get
        {
            return this.propertyField;
        }
        set
        {
            this.propertyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string contains
    {
        get
        {
            return this.containsField;
        }
        set
        {
            this.containsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class conditionalIF
{

    private link[] linkField;

    private string propertyField;

    private string valueField;

    private string containsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public link[] link
    {
        get
        {
            return this.linkField;
        }
        set
        {
            this.linkField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string property
    {
        get
        {
            return this.propertyField;
        }
        set
        {
            this.propertyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string contains
    {
        get
        {
            return this.containsField;
        }
        set
        {
            this.containsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class conditionalSwitch
{

    private conditionalSwitchCase[] caseField;

    private link[] defaultField;

    private string propertyField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("case", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public conditionalSwitchCase[] @case
    {
        get
        {
            return this.caseField;
        }
        set
        {
            this.caseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public link[] @default
    {
        get
        {
            return this.defaultField;
        }
        set
        {
            this.defaultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string property
    {
        get
        {
            return this.propertyField;
        }
        set
        {
            this.propertyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class conditionalSwitchCase
{

    private link[] linkField;

    private string valueField;

    private string containsField;

    private proxyBoolean breakField;

    public conditionalSwitchCase()
    {
        this.breakField = proxyBoolean.True;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public link[] link
    {
        get
        {
            return this.linkField;
        }
        set
        {
            this.linkField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string contains
    {
        get
        {
            return this.containsField;
        }
        set
        {
            this.containsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(proxyBoolean.True)]
    public proxyBoolean @break
    {
        get
        {
            return this.breakField;
        }
        set
        {
            this.breakField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class templatesBlockText
{

    private string colorField;

    private string sizeField;

    private string fontField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string color
    {
        get
        {
            return this.colorField;
        }
        set
        {
            this.colorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string size
    {
        get
        {
            return this.sizeField;
        }
        set
        {
            this.sizeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string font
    {
        get
        {
            return this.fontField;
        }
        set
        {
            this.fontField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class templatesBlockBorder
{

    private string colorField;

    private string sizeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string color
    {
        get
        {
            return this.colorField;
        }
        set
        {
            this.colorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string size
    {
        get
        {
            return this.sizeField;
        }
        set
        {
            this.sizeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class templatesBlockWordwrap
{

    private string heightField;

    private string widthField;

    private alignment alignField;

    private alignment valignField;

    private proxyBoolean shrinktofitField;

    public templatesBlockWordwrap()
    {
        this.alignField = alignment.near;
        this.valignField = alignment.near;
        this.shrinktofitField = proxyBoolean.False;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(alignment.near)]
    public alignment align
    {
        get
        {
            return this.alignField;
        }
        set
        {
            this.alignField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(alignment.near)]
    public alignment valign
    {
        get
        {
            return this.valignField;
        }
        set
        {
            this.valignField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(proxyBoolean.False)]
    public proxyBoolean shrinktofit
    {
        get
        {
            return this.shrinktofitField;
        }
        set
        {
            this.shrinktofitField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
public enum alignment
{

    /// <remarks/>
    near,

    /// <remarks/>
    center,

    /// <remarks/>
    far,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
public enum blocktype
{

    /// <remarks/>
    text,

    /// <remarks/>
    overlay,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class templatesTemplate
{

    private templatesTemplateMatch[] matchesField;

    private object[] overlayblocksField;

    private object[] textblocksField;

    private string srcField;

    private proxyBoolean defaultField;

    public templatesTemplate()
    {
        this.defaultField = proxyBoolean.False;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("match", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public templatesTemplateMatch[] matches
    {
        get
        {
            return this.matchesField;
        }
        set
        {
            this.matchesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute(typeof(artoverlay), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    [System.Xml.Serialization.XmlArrayItemAttribute(typeof(conditional), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    [System.Xml.Serialization.XmlArrayItemAttribute(typeof(link), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public object[] overlayblocks
    {
        get
        {
            return this.overlayblocksField;
        }
        set
        {
            this.overlayblocksField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute(typeof(conditional), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    [System.Xml.Serialization.XmlArrayItemAttribute(typeof(link), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public object[] textblocks
    {
        get
        {
            return this.textblocksField;
        }
        set
        {
            this.textblocksField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string src
    {
        get
        {
            return this.srcField;
        }
        set
        {
            this.srcField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(proxyBoolean.False)]
    public proxyBoolean @default
    {
        get
        {
            return this.defaultField;
        }
        set
        {
            this.defaultField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class templatesTemplateMatch
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}
