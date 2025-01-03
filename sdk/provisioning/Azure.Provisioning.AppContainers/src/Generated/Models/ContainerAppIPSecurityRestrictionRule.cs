// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Rule to restrict incoming IP address.
/// </summary>
public partial class ContainerAppIPSecurityRestrictionRule : ProvisionableConstruct
{
    /// <summary>
    /// Name for the IP restriction rule.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Describe the IP restriction rule that is being sent to the
    /// container-app. This is an optional field.
    /// </summary>
    public BicepValue<string> Description 
    {
        get { Initialize(); return _description!; }
        set { Initialize(); _description!.Assign(value); }
    }
    private BicepValue<string>? _description;

    /// <summary>
    /// CIDR notation to match incoming IP address.
    /// </summary>
    public BicepValue<string> IPAddressRange 
    {
        get { Initialize(); return _iPAddressRange!; }
        set { Initialize(); _iPAddressRange!.Assign(value); }
    }
    private BicepValue<string>? _iPAddressRange;

    /// <summary>
    /// Allow or Deny rules to determine for incoming IP. Note: Rules can only
    /// consist of ALL Allow or ALL Deny.
    /// </summary>
    public BicepValue<ContainerAppIPRuleAction> Action 
    {
        get { Initialize(); return _action!; }
        set { Initialize(); _action!.Assign(value); }
    }
    private BicepValue<ContainerAppIPRuleAction>? _action;

    /// <summary>
    /// Creates a new ContainerAppIPSecurityRestrictionRule.
    /// </summary>
    public ContainerAppIPSecurityRestrictionRule()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerAppIPSecurityRestrictionRule.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"]);
        _description = DefineProperty<string>("Description", ["description"]);
        _iPAddressRange = DefineProperty<string>("IPAddressRange", ["ipAddressRange"]);
        _action = DefineProperty<ContainerAppIPRuleAction>("Action", ["action"]);
    }
}
