﻿
namespace nuComponents.DataTypes.PropertyEditors.EnumRadioButtonPicker
{
    using ClientDependency.Core;
    using Umbraco.Core.PropertyEditors;
    using Umbraco.Web.PropertyEditors;
    using nuComponents.DataTypes.PropertyEditors;

    // EDITOR UI
    [PropertyEditor(PropertyEditorConstants.EnumRadioButtonPickerAlias, "nuComponents: Enum RadioButton Picker", EmbeddedResource.RootUrl + "RadioButtonPicker/RadioButtonPickerEditor.html", ValueType = "TEXT")]
    [PropertyEditorAsset(ClientDependencyType.Css, EmbeddedResource.RootUrl + "LayoutDirection/LayoutDirection.css")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.RootUrl + "RadioButtonPicker/RadioButtonPickerEditorController.js")]

    // RESOURCES (all are referenced as EditorResource consumes the others)
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.RootUrl + "Editor/EditorResource.js")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.RootUrl + "DataSource/DataSourceResource.js")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.RootUrl + "RelationMapping/RelationMappingResource.js")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.RootUrl + "SaveFormat/SaveFormatResource.js")]

    // CONFIG
    [PropertyEditorAsset(ClientDependencyType.Css, EmbeddedResource.RootUrl + "Editor/EditorConfig.css")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.RootUrl + "EnumDataSource/EnumDataSourceConfigController.js")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.RootUrl + "CustomLabel/CustomLabelConfigController.js")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.RootUrl + "RelationMapping/RelationMappingConfigController.js")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.RootUrl + "SaveFormat/SaveFormatConfigController.js")]
    public class EnumRadioButtonPickerPropertyEditor : BasePropertyEditor
    {
        protected override PreValueEditor CreatePreValueEditor()
        {
            return new EnumRadioButtonPickerPreValueEditor();
        }
    }
}
