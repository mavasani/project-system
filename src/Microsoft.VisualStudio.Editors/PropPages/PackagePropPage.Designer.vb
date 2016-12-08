' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Namespace Microsoft.VisualStudio.Editors.PropertyPages

    Partial Class PackagePropPage

        Private _components As System.ComponentModel.IContainer

        Protected Overloads Overrides Sub Dispose(disposing As Boolean)
            If disposing Then
                If Not (_components Is Nothing) Then
                    _components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PackagePropPage))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.AssemblyInfoPropPage1 = New Microsoft.VisualStudio.Editors.PropertyPages.AssemblyInfoPropPage()
            Me.label_AssemblyInfoProperties = New System.Windows.Forms.Label()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.PackageIdLabel = New System.Windows.Forms.Label()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.PackageVersionLabel = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.PackagePropertiesLabel = New System.Windows.Forms.Label()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.AuthorsLabel = New System.Windows.Forms.Label()
            Me.TextBox4 = New System.Windows.Forms.TextBox()
            Me.SummaryLabel = New System.Windows.Forms.Label()
            Me.TextBox5 = New System.Windows.Forms.TextBox()
            Me.LicenseUrlLabel = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TextBox6 = New System.Windows.Forms.TextBox()
            Me.IconUrlLabel = New System.Windows.Forms.Label()
            Me.TextBox7 = New System.Windows.Forms.TextBox()
            Me.PackageTagsLabel = New System.Windows.Forms.Label()
            Me.TextBox8 = New System.Windows.Forms.TextBox()
            Me.TextBox9 = New System.Windows.Forms.TextBox()
            Me.ReleaseNotesLabel = New System.Windows.Forms.Label()
            Me.RepoUrlLabel = New System.Windows.Forms.Label()
            Me.RepoTypeLabel = New System.Windows.Forms.Label()
            Me.TextBox10 = New System.Windows.Forms.TextBox()
            Me.TextBox11 = New System.Windows.Forms.TextBox()
            Me.TextBox12 = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.RequiresLicenseAcceptanceCheckBox = New System.Windows.Forms.CheckBox()
            Me.EnablePackOnBuildCheckBox = New System.Windows.Forms.CheckBox()
            Me.Panel1.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.AssemblyInfoPropPage1)
            Me.Panel1.Controls.Add(Me.label_AssemblyInfoProperties)
            resources.ApplyResources(Me.Panel1, "Panel1")
            Me.Panel1.Name = "Panel1"
            '
            'AssemblyInfoPropPage1
            '
            Me.AssemblyInfoPropPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.PropertyPage
            resources.ApplyResources(Me.AssemblyInfoPropPage1, "AssemblyInfoPropPage1")
            Me.AssemblyInfoPropPage1.BackColor = System.Drawing.SystemColors.Control
            Me.AssemblyInfoPropPage1.IsDirty = False
            Me.AssemblyInfoPropPage1.Name = "AssemblyInfoPropPage1"
            '
            'label_AssemblyInfoProperties
            '
            resources.ApplyResources(Me.label_AssemblyInfoProperties, "label_AssemblyInfoProperties")
            Me.label_AssemblyInfoProperties.Name = "label_AssemblyInfoProperties"
            '
            'TableLayoutPanel1
            '
            resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox7, 1, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.IconUrlLabel, 0, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox6, 1, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.PackageIdLabel, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.PackageVersionLabel, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 1, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox5, 1, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 1, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.AuthorsLabel, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.LicenseUrlLabel, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox8, 1, 8)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox9, 1, 9)
            Me.TableLayoutPanel1.Controls.Add(Me.PackageTagsLabel, 0, 10)
            Me.TableLayoutPanel1.Controls.Add(Me.RepoUrlLabel, 0, 8)
            Me.TableLayoutPanel1.Controls.Add(Me.ReleaseNotesLabel, 0, 11)
            Me.TableLayoutPanel1.Controls.Add(Me.RepoTypeLabel, 0, 9)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox10, 1, 10)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox11, 1, 11)
            Me.TableLayoutPanel1.Controls.Add(Me.SummaryLabel, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox12, 1, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.RequiresLicenseAcceptanceCheckBox, 0, 13)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            '
            'TextBox1
            '
            resources.ApplyResources(Me.TextBox1, "TextBox1")
            Me.TextBox1.Name = "TextBox1"
            '
            'PackageIdLabel
            '
            resources.ApplyResources(Me.PackageIdLabel, "PackageIdLabel")
            Me.PackageIdLabel.Name = "PackageIdLabel"
            '
            'TextBox2
            '
            resources.ApplyResources(Me.TextBox2, "TextBox2")
            Me.TextBox2.Name = "TextBox2"
            '
            'PackageVersionLabel
            '
            resources.ApplyResources(Me.PackageVersionLabel, "PackageVersionLabel")
            Me.PackageVersionLabel.Name = "PackageVersionLabel"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.PackagePropertiesLabel)
            Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
            resources.ApplyResources(Me.Panel2, "Panel2")
            Me.Panel2.Name = "Panel2"
            '
            'PackagePropertiesLabel
            '
            resources.ApplyResources(Me.PackagePropertiesLabel, "PackagePropertiesLabel")
            Me.PackagePropertiesLabel.Name = "PackagePropertiesLabel"
            '
            'TextBox3
            '
            resources.ApplyResources(Me.TextBox3, "TextBox3")
            Me.TextBox3.Name = "TextBox3"
            '
            'AuthorsLabel
            '
            resources.ApplyResources(Me.AuthorsLabel, "AuthorsLabel")
            Me.AuthorsLabel.Name = "AuthorsLabel"
            '
            'TextBox4
            '
            resources.ApplyResources(Me.TextBox4, "TextBox4")
            Me.TextBox4.Name = "TextBox4"
            '
            'SummaryLabel
            '
            resources.ApplyResources(Me.SummaryLabel, "SummaryLabel")
            Me.SummaryLabel.Name = "SummaryLabel"
            '
            'TextBox5
            '
            resources.ApplyResources(Me.TextBox5, "TextBox5")
            Me.TextBox5.Name = "TextBox5"
            '
            'LicenseUrlLabel
            '
            resources.ApplyResources(Me.LicenseUrlLabel, "LicenseUrlLabel")
            Me.LicenseUrlLabel.Name = "LicenseUrlLabel"
            '
            'Label1
            '
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.Name = "Label1"
            '
            'TextBox6
            '
            resources.ApplyResources(Me.TextBox6, "TextBox6")
            Me.TextBox6.Name = "TextBox6"
            '
            'IconUrlLabel
            '
            resources.ApplyResources(Me.IconUrlLabel, "IconUrlLabel")
            Me.IconUrlLabel.Name = "IconUrlLabel"
            '
            'TextBox7
            '
            resources.ApplyResources(Me.TextBox7, "TextBox7")
            Me.TextBox7.Name = "TextBox7"
            '
            'PackageTagsLabel
            '
            resources.ApplyResources(Me.PackageTagsLabel, "PackageTagsLabel")
            Me.PackageTagsLabel.Name = "PackageTagsLabel"
            '
            'TextBox8
            '
            resources.ApplyResources(Me.TextBox8, "TextBox8")
            Me.TextBox8.Name = "TextBox8"
            '
            'TextBox9
            '
            resources.ApplyResources(Me.TextBox9, "TextBox9")
            Me.TextBox9.Name = "TextBox9"
            '
            'ReleaseNotesLabel
            '
            resources.ApplyResources(Me.ReleaseNotesLabel, "ReleaseNotesLabel")
            Me.ReleaseNotesLabel.Name = "ReleaseNotesLabel"
            '
            'RepoUrlLabel
            '
            resources.ApplyResources(Me.RepoUrlLabel, "RepoUrlLabel")
            Me.RepoUrlLabel.Name = "RepoUrlLabel"
            '
            'RepoTypeLabel
            '
            resources.ApplyResources(Me.RepoTypeLabel, "RepoTypeLabel")
            Me.RepoTypeLabel.Name = "RepoTypeLabel"
            '
            'TextBox10
            '
            resources.ApplyResources(Me.TextBox10, "TextBox10")
            Me.TextBox10.Name = "TextBox10"
            '
            'TextBox11
            '
            resources.ApplyResources(Me.TextBox11, "TextBox11")
            Me.TextBox11.Name = "TextBox11"
            '
            'TextBox12
            '
            resources.ApplyResources(Me.TextBox12, "TextBox12")
            Me.TextBox12.Name = "TextBox12"
            '
            'Label2
            '
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.Name = "Label2"
            '
            'RequiresLicenseAcceptanceCheckBox
            '
            resources.ApplyResources(Me.RequiresLicenseAcceptanceCheckBox, "RequiresLicenseAcceptanceCheckBox")
            Me.RequiresLicenseAcceptanceCheckBox.Checked = True
            Me.RequiresLicenseAcceptanceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.TableLayoutPanel1.SetColumnSpan(Me.RequiresLicenseAcceptanceCheckBox, 2)
            Me.RequiresLicenseAcceptanceCheckBox.Name = "RequiresLicenseAcceptanceCheckBox"
            '
            'EnablePackOnBuildCheckBox
            '
            resources.ApplyResources(Me.EnablePackOnBuildCheckBox, "EnablePackOnBuildCheckBox")
            Me.EnablePackOnBuildCheckBox.Checked = True
            Me.EnablePackOnBuildCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.EnablePackOnBuildCheckBox.Name = "EnablePackOnBuildCheckBox"
            '
            'PackageAndAssemblyInfoPropPage
            '
            Me.Controls.Add(Me.EnablePackOnBuildCheckBox)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "PackageAndAssemblyInfoPropPage"
            resources.ApplyResources(Me, "$this")
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Panel1 As Windows.Forms.Panel
        Friend WithEvents label_AssemblyInfoProperties As Windows.Forms.Label
        Friend WithEvents AssemblyInfoPropPage1 As AssemblyInfoPropPage
        Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
        Friend WithEvents Panel2 As Windows.Forms.Panel
        Friend WithEvents PackagePropertiesLabel As Windows.Forms.Label
        Friend WithEvents TextBox1 As Windows.Forms.TextBox
        Friend WithEvents PackageIdLabel As Windows.Forms.Label
        Friend WithEvents TextBox2 As Windows.Forms.TextBox
        Friend WithEvents PackageVersionLabel As Windows.Forms.Label
        Friend WithEvents SummaryLabel As Windows.Forms.Label
        Friend WithEvents TextBox4 As Windows.Forms.TextBox
        Friend WithEvents TextBox5 As Windows.Forms.TextBox
        Friend WithEvents TextBox3 As Windows.Forms.TextBox
        Friend WithEvents AuthorsLabel As Windows.Forms.Label
        Friend WithEvents LicenseUrlLabel As Windows.Forms.Label
        Friend WithEvents Label1 As Windows.Forms.Label
        Friend WithEvents IconUrlLabel As Windows.Forms.Label
        Friend WithEvents TextBox6 As Windows.Forms.TextBox
        Friend WithEvents TextBox7 As Windows.Forms.TextBox
        Friend WithEvents PackageTagsLabel As Windows.Forms.Label
        Friend WithEvents TextBox8 As Windows.Forms.TextBox
        Friend WithEvents TextBox9 As Windows.Forms.TextBox
        Friend WithEvents ReleaseNotesLabel As Windows.Forms.Label
        Friend WithEvents RepoUrlLabel As Windows.Forms.Label
        Friend WithEvents RepoTypeLabel As Windows.Forms.Label
        Friend WithEvents TextBox10 As Windows.Forms.TextBox
        Friend WithEvents TextBox11 As Windows.Forms.TextBox
        Friend WithEvents TextBox12 As Windows.Forms.TextBox
        Friend WithEvents Label2 As Windows.Forms.Label
        Friend WithEvents RequiresLicenseAcceptanceCheckBox As Windows.Forms.CheckBox
        Friend WithEvents EnablePackOnBuildCheckBox As Windows.Forms.CheckBox
    End Class

End Namespace
