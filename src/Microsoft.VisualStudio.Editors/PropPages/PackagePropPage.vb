' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports System.ComponentModel
Imports System.Globalization
Imports VSLangProj80
Imports System.Windows.Forms

Imports Microsoft.VisualStudio.Editors.Common

Namespace Microsoft.VisualStudio.Editors.PropertyPages

    Friend Class PackagePropPage
        Inherits PropPageUserControlBase

        ''' <summary>
        ''' Customizable processing done before the class has populated controls in the ControlData array
        ''' </summary>
        ''' <remarks>
        ''' Override this to implement custom processing.
        ''' IMPORTANT NOTE: this method can be called multiple times on the same page.  In particular,
        '''   it is called on every SetObjects call, which means that when the user changes the
        '''   selected configuration, it is called again. 
        ''' </remarks>
        Protected Overrides Sub PreInitPage()
            MyBase.PreInitPage()
        End Sub

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call

            AddChangeHandlers()

            MyBase.PageRequiresScaling = False
        End Sub

        Protected Overrides ReadOnly Property ControlData() As PropertyControlData()
            Get
                If m_ControlData Is Nothing Then

                    Dim datalist As List(Of PropertyControlData) = New List(Of PropertyControlData)
                    'Dim data As PropertyControlData = New PropertyControlData(VsProjPropId80.VBPROJPROPID_AssemblyTitle, "Title", Me.Title, ControlDataFlags.PersistedInAssemblyInfoFile, New Control() {Me.TitleLabel})
                    'datalist.Add(data)


                    m_ControlData = datalist.ToArray()
                End If
                Return m_ControlData
            End Get
        End Property

        Protected Overrides Function GetF1HelpKeyword() As String
            Return HelpKeywords.VBProjPropAssemblyInfo
        End Function
    End Class

End Namespace
