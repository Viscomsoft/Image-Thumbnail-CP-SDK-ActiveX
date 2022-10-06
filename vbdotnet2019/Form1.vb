Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents btnbgcolor As System.Windows.Forms.Button
    Friend WithEvents btnclipcolor As System.Windows.Forms.Button
    Friend WithEvents btnhighlightcolor As System.Windows.Forms.Button
    Friend WithEvents btnbordercolor As System.Windows.Forms.Button
    Friend WithEvents btnshadowcolor As System.Windows.Forms.Button
    Friend WithEvents btntextcolor As System.Windows.Forms.Button
    Friend WithEvents btnupdatetext As System.Windows.Forms.Button
    Friend WithEvents btnacdsee As System.Windows.Forms.Button
    Friend WithEvents btnnormal As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents chkfontbold As System.Windows.Forms.CheckBox
    Friend WithEvents chkfontItalic As System.Windows.Forms.CheckBox
    Friend WithEvents chkfontunderline As System.Windows.Forms.CheckBox
    Friend WithEvents btnmargin As System.Windows.Forms.Button
    Friend WithEvents txttopmargin As System.Windows.Forms.TextBox
    Friend WithEvents txtbottommargin As System.Windows.Forms.TextBox
    Friend WithEvents txtfontsize As System.Windows.Forms.TextBox
    Friend WithEvents btnfontsize As System.Windows.Forms.Button
    Friend WithEvents txtFontTop As System.Windows.Forms.TextBox
    Friend WithEvents btnfonttop As System.Windows.Forms.Button
    Friend WithEvents txtClipWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtClipHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentIndex As System.Windows.Forms.TextBox
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboscrollbar As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbodisplaymode As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPageNo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents AxImageThumbnailCP1 As AxIMAGETHUMBNAILCPLib.AxImageThumbnailCP
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents cbofilter As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnbgcolor = New System.Windows.Forms.Button()
        Me.btnclipcolor = New System.Windows.Forms.Button()
        Me.btnhighlightcolor = New System.Windows.Forms.Button()
        Me.btnbordercolor = New System.Windows.Forms.Button()
        Me.btnshadowcolor = New System.Windows.Forms.Button()
        Me.btntextcolor = New System.Windows.Forms.Button()
        Me.btnupdatetext = New System.Windows.Forms.Button()
        Me.btnacdsee = New System.Windows.Forms.Button()
        Me.btnnormal = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCurrentIndex = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttopmargin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbottommargin = New System.Windows.Forms.TextBox()
        Me.btnmargin = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfontsize = New System.Windows.Forms.TextBox()
        Me.btnfontsize = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFontTop = New System.Windows.Forms.TextBox()
        Me.btnfonttop = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtClipWidth = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtClipHeight = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.chkfontbold = New System.Windows.Forms.CheckBox()
        Me.chkfontItalic = New System.Windows.Forms.CheckBox()
        Me.chkfontunderline = New System.Windows.Forms.CheckBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboscrollbar = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbodisplaymode = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPageNo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbofilter = New System.Windows.Forms.ComboBox()
        Me.AxImageThumbnailCP1 = New AxIMAGETHUMBNAILCPLib.AxImageThumbnailCP()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.AxImageThumbnailCP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(817, 192)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(163, 26)
        Me.btnadd.TabIndex = 1
        Me.btnadd.Text = "Add"
        '
        'btnbgcolor
        '
        Me.btnbgcolor.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbgcolor.Location = New System.Drawing.Point(819, 259)
        Me.btnbgcolor.Name = "btnbgcolor"
        Me.btnbgcolor.Size = New System.Drawing.Size(163, 25)
        Me.btnbgcolor.TabIndex = 2
        Me.btnbgcolor.Text = "Background Color"
        '
        'btnclipcolor
        '
        Me.btnclipcolor.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclipcolor.Location = New System.Drawing.Point(819, 293)
        Me.btnclipcolor.Name = "btnclipcolor"
        Me.btnclipcolor.Size = New System.Drawing.Size(163, 26)
        Me.btnclipcolor.TabIndex = 3
        Me.btnclipcolor.Text = "Clip Color"
        '
        'btnhighlightcolor
        '
        Me.btnhighlightcolor.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhighlightcolor.Location = New System.Drawing.Point(819, 328)
        Me.btnhighlightcolor.Name = "btnhighlightcolor"
        Me.btnhighlightcolor.Size = New System.Drawing.Size(163, 26)
        Me.btnhighlightcolor.TabIndex = 4
        Me.btnhighlightcolor.Text = "Highlight color"
        '
        'btnbordercolor
        '
        Me.btnbordercolor.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbordercolor.Location = New System.Drawing.Point(819, 362)
        Me.btnbordercolor.Name = "btnbordercolor"
        Me.btnbordercolor.Size = New System.Drawing.Size(163, 26)
        Me.btnbordercolor.TabIndex = 5
        Me.btnbordercolor.Text = "Border color"
        '
        'btnshadowcolor
        '
        Me.btnshadowcolor.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshadowcolor.Location = New System.Drawing.Point(819, 396)
        Me.btnshadowcolor.Name = "btnshadowcolor"
        Me.btnshadowcolor.Size = New System.Drawing.Size(163, 26)
        Me.btnshadowcolor.TabIndex = 6
        Me.btnshadowcolor.Text = "Shadow color"
        '
        'btntextcolor
        '
        Me.btntextcolor.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntextcolor.Location = New System.Drawing.Point(819, 431)
        Me.btntextcolor.Name = "btntextcolor"
        Me.btntextcolor.Size = New System.Drawing.Size(163, 26)
        Me.btntextcolor.TabIndex = 7
        Me.btntextcolor.Text = "Text color"
        '
        'btnupdatetext
        '
        Me.btnupdatetext.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdatetext.Location = New System.Drawing.Point(819, 466)
        Me.btnupdatetext.Name = "btnupdatetext"
        Me.btnupdatetext.Size = New System.Drawing.Size(163, 26)
        Me.btnupdatetext.TabIndex = 8
        Me.btnupdatetext.Text = "Update Caption Text"
        '
        'btnacdsee
        '
        Me.btnacdsee.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnacdsee.Location = New System.Drawing.Point(819, 500)
        Me.btnacdsee.Name = "btnacdsee"
        Me.btnacdsee.Size = New System.Drawing.Size(163, 26)
        Me.btnacdsee.TabIndex = 9
        Me.btnacdsee.Text = "ACDSee Style"
        '
        'btnnormal
        '
        Me.btnnormal.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnormal.Location = New System.Drawing.Point(819, 534)
        Me.btnnormal.Name = "btnnormal"
        Me.btnnormal.Size = New System.Drawing.Size(163, 26)
        Me.btnnormal.TabIndex = 10
        Me.btnnormal.Text = "Normal Style"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 490)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Current Index"
        '
        'txtCurrentIndex
        '
        Me.txtCurrentIndex.Location = New System.Drawing.Point(171, 490)
        Me.txtCurrentIndex.Name = "txtCurrentIndex"
        Me.txtCurrentIndex.Size = New System.Drawing.Size(96, 21)
        Me.txtCurrentIndex.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 516)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Clip Top Margin"
        '
        'txttopmargin
        '
        Me.txttopmargin.Location = New System.Drawing.Point(171, 516)
        Me.txttopmargin.Name = "txttopmargin"
        Me.txttopmargin.Size = New System.Drawing.Size(48, 21)
        Me.txttopmargin.TabIndex = 16
        Me.txttopmargin.Text = "0"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 516)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Clip BottomMargin"
        '
        'txtbottommargin
        '
        Me.txtbottommargin.Location = New System.Drawing.Point(382, 516)
        Me.txtbottommargin.Name = "txtbottommargin"
        Me.txtbottommargin.Size = New System.Drawing.Size(48, 21)
        Me.txtbottommargin.TabIndex = 18
        Me.txtbottommargin.Text = "0"
        '
        'btnmargin
        '
        Me.btnmargin.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmargin.Location = New System.Drawing.Point(439, 516)
        Me.btnmargin.Name = "btnmargin"
        Me.btnmargin.Size = New System.Drawing.Size(58, 26)
        Me.btnmargin.TabIndex = 19
        Me.btnmargin.Text = "Set"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 542)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "File Name"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(171, 542)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(374, 21)
        Me.txtFileName.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 568)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Font Size"
        '
        'txtfontsize
        '
        Me.txtfontsize.Location = New System.Drawing.Point(171, 568)
        Me.txtfontsize.Name = "txtfontsize"
        Me.txtfontsize.Size = New System.Drawing.Size(38, 21)
        Me.txtfontsize.TabIndex = 23
        Me.txtfontsize.Text = "8"
        '
        'btnfontsize
        '
        Me.btnfontsize.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfontsize.Location = New System.Drawing.Point(219, 568)
        Me.btnfontsize.Name = "btnfontsize"
        Me.btnfontsize.Size = New System.Drawing.Size(48, 26)
        Me.btnfontsize.TabIndex = 24
        Me.btnfontsize.Text = "Set"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(286, 568)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Font Top"
        '
        'txtFontTop
        '
        Me.txtFontTop.Location = New System.Drawing.Point(391, 568)
        Me.txtFontTop.Name = "txtFontTop"
        Me.txtFontTop.Size = New System.Drawing.Size(39, 21)
        Me.txtFontTop.TabIndex = 26
        Me.txtFontTop.Text = "0"
        '
        'btnfonttop
        '
        Me.btnfonttop.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfonttop.Location = New System.Drawing.Point(439, 568)
        Me.btnfonttop.Name = "btnfonttop"
        Me.btnfonttop.Size = New System.Drawing.Size(58, 26)
        Me.btnfonttop.TabIndex = 27
        Me.btnfonttop.Text = "Set"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 602)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 18)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Clip Width"
        '
        'txtClipWidth
        '
        Me.txtClipWidth.Location = New System.Drawing.Point(171, 602)
        Me.txtClipWidth.Name = "txtClipWidth"
        Me.txtClipWidth.Size = New System.Drawing.Size(76, 21)
        Me.txtClipWidth.TabIndex = 29
        Me.txtClipWidth.Text = "80"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(257, 602)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 18)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Clip Height"
        '
        'txtClipHeight
        '
        Me.txtClipHeight.Location = New System.Drawing.Point(353, 602)
        Me.txtClipHeight.Name = "txtClipHeight"
        Me.txtClipHeight.Size = New System.Drawing.Size(77, 21)
        Me.txtClipHeight.TabIndex = 31
        Me.txtClipHeight.Text = "80"
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(439, 602)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(58, 26)
        Me.Button13.TabIndex = 32
        Me.Button13.Text = "Set"
        '
        'chkfontbold
        '
        Me.chkfontbold.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkfontbold.Location = New System.Drawing.Point(614, 450)
        Me.chkfontbold.Name = "chkfontbold"
        Me.chkfontbold.Size = New System.Drawing.Size(154, 18)
        Me.chkfontbold.TabIndex = 33
        Me.chkfontbold.Text = "Clip Font Bold"
        '
        'chkfontItalic
        '
        Me.chkfontItalic.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkfontItalic.Location = New System.Drawing.Point(614, 485)
        Me.chkfontItalic.Name = "chkfontItalic"
        Me.chkfontItalic.Size = New System.Drawing.Size(154, 17)
        Me.chkfontItalic.TabIndex = 34
        Me.chkfontItalic.Text = "Clip Font Italic"
        '
        'chkfontunderline
        '
        Me.chkfontunderline.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkfontunderline.Location = New System.Drawing.Point(614, 519)
        Me.chkfontunderline.Name = "chkfontunderline"
        Me.chkfontunderline.Size = New System.Drawing.Size(154, 17)
        Me.chkfontunderline.TabIndex = 35
        Me.chkfontunderline.Text = "Clip Font Underline"
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(819, 568)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(163, 26)
        Me.Button14.TabIndex = 36
        Me.Button14.Text = "Delete All"
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(819, 603)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(163, 26)
        Me.Button15.TabIndex = 37
        Me.Button15.Text = "Delete Selected Clip"
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(788, 700)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(192, 26)
        Me.Button16.TabIndex = 38
        Me.Button16.Text = "Display Selected FileName"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(817, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 25)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Scroll Bar"
        '
        'cboscrollbar
        '
        Me.cboscrollbar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboscrollbar.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboscrollbar.Location = New System.Drawing.Point(817, 36)
        Me.cboscrollbar.Name = "cboscrollbar"
        Me.cboscrollbar.Size = New System.Drawing.Size(183, 20)
        Me.cboscrollbar.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(817, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 18)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Display Mode"
        '
        'cbodisplaymode
        '
        Me.cbodisplaymode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodisplaymode.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodisplaymode.Location = New System.Drawing.Point(817, 80)
        Me.cbodisplaymode.Name = "cbodisplaymode"
        Me.cbodisplaymode.Size = New System.Drawing.Size(183, 20)
        Me.cbodisplaymode.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(35, 711)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(461, 17)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "If the clip size is big, you should use high Display Mode property"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(38, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(375, 18)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = " you can drag the image to reorder the position"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(817, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 26)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Add File from folder"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button2.Location = New System.Drawing.Point(16, 736)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 26)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Select One Clip"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button3.Location = New System.Drawing.Point(169, 736)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 26)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "Select Multiple Clips"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button4.Location = New System.Drawing.Point(352, 736)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(163, 26)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "UnSelect Multiple Clips"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button5.Location = New System.Drawing.Point(534, 736)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(154, 26)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "Visible clips"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(46, 450)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 17)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Page No"
        '
        'txtPageNo
        '
        Me.txtPageNo.Location = New System.Drawing.Point(171, 450)
        Me.txtPageNo.Name = "txtPageNo"
        Me.txtPageNo.Size = New System.Drawing.Size(76, 21)
        Me.txtPageNo.TabIndex = 51
        Me.txtPageNo.Text = "1"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(817, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(154, 17)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Folder Filter"
        '
        'cbofilter
        '
        Me.cbofilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofilter.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbofilter.Location = New System.Drawing.Point(817, 123)
        Me.cbofilter.Name = "cbofilter"
        Me.cbofilter.Size = New System.Drawing.Size(183, 20)
        Me.cbofilter.TabIndex = 53
        '
        'AxImageThumbnailCP1
        '
        Me.AxImageThumbnailCP1.Enabled = True
        Me.AxImageThumbnailCP1.Location = New System.Drawing.Point(40, 29)
        Me.AxImageThumbnailCP1.Name = "AxImageThumbnailCP1"
        Me.AxImageThumbnailCP1.OcxState = CType(resources.GetObject("AxImageThumbnailCP1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageThumbnailCP1.Size = New System.Drawing.Size(745, 407)
        Me.AxImageThumbnailCP1.TabIndex = 54
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(819, 224)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(163, 25)
        Me.Button6.TabIndex = 55
        Me.Button6.Text = "Get PDF Information"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1022, 682)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.AxImageThumbnailCP1)
        Me.Controls.Add(Me.cbofilter)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtPageNo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbodisplaymode)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboscrollbar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.chkfontunderline)
        Me.Controls.Add(Me.chkfontItalic)
        Me.Controls.Add(Me.chkfontbold)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.txtClipHeight)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtClipWidth)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnfonttop)
        Me.Controls.Add(Me.txtFontTop)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnfontsize)
        Me.Controls.Add(Me.txtfontsize)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnmargin)
        Me.Controls.Add(Me.txtbottommargin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttopmargin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCurrentIndex)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnnormal)
        Me.Controls.Add(Me.btnacdsee)
        Me.Controls.Add(Me.btnupdatetext)
        Me.Controls.Add(Me.btntextcolor)
        Me.Controls.Add(Me.btnshadowcolor)
        Me.Controls.Add(Me.btnbordercolor)
        Me.Controls.Add(Me.btnhighlightcolor)
        Me.Controls.Add(Me.btnclipcolor)
        Me.Controls.Add(Me.btnbgcolor)
        Me.Controls.Add(Me.btnadd)
        Me.Name = "Form1"
        Me.Text = "Image Thumbnail cp ActiveX"
        CType(Me.AxImageThumbnailCP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim oldBackColor As Color
    Dim oldBorderColor As Color
    Dim oldShadowColor As Color
    Dim oldClipColor As Color

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico||"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            AxImageThumbnailCP1.UnSelectAllClip()
            AxImageThumbnailCP1.AddClip(OpenFileDialog1.FileName, "")
            AxImageThumbnailCP1.SelectClip(AxImageThumbnailCP1.ClipCount - 1)
            AxImageThumbnailCP1.VScroll(7)
            AxImageThumbnailCP1.Focus()
        End If
    End Sub


    Private Sub btnbgcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbgcolor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            AxImageThumbnailCP1.BackgroundColor = ColorDialog1.Color
            AxImageThumbnailCP1.Focus()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cbofilter.Items.Add("JPG|BMP|GIF|PNG")
        cbofilter.Items.Add("JPG|BMP|GIF|PNG|PSD|TIF")
        cbofilter.Items.Add("PDF|TIF")
        cbofilter.Items.Add("All Supported Image formats")
        cbofilter.SelectedIndex = 3




        oldBackColor = AxImageThumbnailCP1.BackgroundColor
        oldBorderColor = AxImageThumbnailCP1.ClipBorderColor
        oldShadowColor = AxImageThumbnailCP1.ClipShadowColor
        oldClipColor = AxImageThumbnailCP1.ClipColor

        cboscrollbar.Items.Add("Vertical")
        cboscrollbar.Items.Add("Horizontal")
        cboscrollbar.SelectedIndex = 0

        cbodisplaymode.Items.Add("Fast Speed, poor Quality")
        cbodisplaymode.Items.Add("Normal Speed, Normal Quality")
        cbodisplaymode.Items.Add("Slow Speed, High Quality")
        cbodisplaymode.Items.Add("Very Slow Speed, Best Quality")
        cbodisplaymode.SelectedIndex = 1





    End Sub

    Private Sub btnclipcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclipcolor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            AxImageThumbnailCP1.ClipColor = ColorDialog1.Color
            AxImageThumbnailCP1.Focus()
        End If

    End Sub

    Private Sub btnhighlightcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhighlightcolor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            AxImageThumbnailCP1.ClipHighlightColor = ColorDialog1.Color
            AxImageThumbnailCP1.Focus()
        End If

    End Sub

    Private Sub btnbordercolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbordercolor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            AxImageThumbnailCP1.ClipBorderColor = ColorDialog1.Color
            AxImageThumbnailCP1.Focus()
        End If

    End Sub

    Private Sub btnshadowcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshadowcolor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            AxImageThumbnailCP1.ClipShadowColor = ColorDialog1.Color
            AxImageThumbnailCP1.Focus()
        End If

    End Sub

    Private Sub btntextcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntextcolor.Click

        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            AxImageThumbnailCP1.ClipTextColor = ColorDialog1.Color
            AxImageThumbnailCP1.Focus()
        End If

    End Sub

    Private Sub btnupdatetext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdatetext.Click
        Dim iCount As Integer
        Dim i As Integer

        iCount = AxImageThumbnailCP1.ClipCount


        For i = 0 To iCount
            AxImageThumbnailCP1.SetClipInfo(i, "", " Demo " + Convert.ToString(i))
        Next

        AxImageThumbnailCP1.Focus()

    End Sub

    Private Sub btnacdsee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnacdsee.Click
        Dim Color1 As Color = Color.FromArgb(128, 128, 128)
        Dim iCount As Integer
        Dim i As Integer

        AxImageThumbnailCP1.BackgroundColor = Color1
        AxImageThumbnailCP1.ClipBorderColor = Color1
        AxImageThumbnailCP1.ClipShadowColor = Color1
        AxImageThumbnailCP1.ClipColor = Color1
        AxImageThumbnailCP1.ClipFontSize = 10
        AxImageThumbnailCP1.ClipFontName = "Arial"
        AxImageThumbnailCP1.ClipFontTopPos = 95
        AxImageThumbnailCP1.ClipTopMargin = 0
        AxImageThumbnailCP1.ClipBottomMargin = 15
        AxImageThumbnailCP1.ClipWidth = 110
        AxImageThumbnailCP1.ClipHeight = 120

        iCount = AxImageThumbnailCP1.ClipCount

        For i = 0 To iCount
            AxImageThumbnailCP1.SetClipInfo(i, "", " Demo " + Convert.ToString(i))
        Next

        AxImageThumbnailCP1.Focus()


    End Sub

    Private Sub btnnormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnormal.Click
        AxImageThumbnailCP1.BackgroundColor = oldBackColor
        AxImageThumbnailCP1.ClipBorderColor = oldBorderColor
        AxImageThumbnailCP1.ClipShadowColor = oldShadowColor
        AxImageThumbnailCP1.ClipColor = oldClipColor
    End Sub

    Private Sub chkfontbold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfontbold.CheckedChanged
        If chkfontbold.Checked Then
            AxImageThumbnailCP1.ClipFontBold = True
        Else
            AxImageThumbnailCP1.ClipFontBold = False

        End If
    End Sub

    Private Sub chkfontItalic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfontItalic.CheckedChanged

        If chkfontItalic.Checked Then
            AxImageThumbnailCP1.ClipFontItalic = True
        Else
            AxImageThumbnailCP1.ClipFontItalic = False

        End If
    End Sub

    Private Sub chkfontunderline_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfontunderline.CheckedChanged
        If chkfontunderline.Checked Then
            AxImageThumbnailCP1.ClipFontUnderline = True
        Else
            AxImageThumbnailCP1.ClipFontUnderline = False
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim iCount As Integer
        Dim i As Integer

        iCount = AxImageThumbnailCP1.ClipCount

        For i = 0 To iCount
            AxImageThumbnailCP1.DeleteClipByIndex(0)
        Next

        AxImageThumbnailCP1.Focus()

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        AxImageThumbnailCP1.DeleteSelectedClip()
        AxImageThumbnailCP1.Focus()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim i As Integer

        For i = 0 To AxImageThumbnailCP1.ClipCount

            If AxImageThumbnailCP1.GetSelect(i) Then
                MessageBox.Show(AxImageThumbnailCP1.GetClipFilePath(i))
            End If
        Next
    End Sub

    Private Sub btnmargin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmargin.Click
        AxImageThumbnailCP1.ClipTopMargin = txttopmargin.Text
        AxImageThumbnailCP1.ClipBottomMargin = txtbottommargin.Text
    End Sub

    Private Sub btnfontsize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfontsize.Click
        AxImageThumbnailCP1.ClipFontSize = txtfontsize.Text
    End Sub

    Private Sub btnfonttop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfonttop.Click
        AxImageThumbnailCP1.ClipFontTopPos = txtFontTop.Text
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        AxImageThumbnailCP1.ClipWidth = txtClipWidth.Text
        AxImageThumbnailCP1.ClipHeight = txtClipHeight.Text
    End Sub



    Private Sub cboscrollbar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboscrollbar.SelectedIndexChanged



        AxImageThumbnailCP1.ScrollBarType = cboscrollbar.SelectedIndex

        If cboscrollbar.SelectedIndex = 0 Then
            AxImageThumbnailCP1.Height = 328
        Else

            AxImageThumbnailCP1.Height = 150


        End If
        AxImageThumbnailCP1.Refresh()





    End Sub

    Private Sub cboscrollbar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboscrollbar.Click

    End Sub

    Private Sub cbodisplaymode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbodisplaymode.SelectedIndexChanged
        AxImageThumbnailCP1.DisplayMode = cbodisplaymode.SelectedIndex
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strpath As String

        strpath = AxImageThumbnailCP1.BrowseFolder("select folder")

        Select Case cbofilter.SelectedIndex

            Case 0
                Me.AxImageThumbnailCP1.AddClipsFromFolder(strpath, "jpg|bmp|gif|png")
            Case 1
                Me.AxImageThumbnailCP1.AddClipsFromFolder(strpath, "jpg|bmp|gif|png|psd|tif")
            Case 2
                Me.AxImageThumbnailCP1.AddClipsFromFolder(strpath, "pdf|tif")
            Case 3
                Me.AxImageThumbnailCP1.AddClipsFromFolder(strpath, "psd|pdf|tif|pcx|png|gif|tga|wbmp|wmf|j2k|jp2|j2c|pgx|ras|pmn|ico|bmp|jpg|png")
        End Select


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxImageThumbnailCP1.UnSelectAllClip()
        AxImageThumbnailCP1.SelectClip(0)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AxImageThumbnailCP1.UnSelectAllClip()
        AxImageThumbnailCP1.SelectClip(1)
        AxImageThumbnailCP1.SelectClip(2)
        AxImageThumbnailCP1.SelectClip(3)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AxImageThumbnailCP1.UnSelectClip(1)
        AxImageThumbnailCP1.UnSelectClip(2)
        AxImageThumbnailCP1.UnSelectClip(3)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim iFirstClip As Integer
        Dim i As Integer
        Dim iTotalVisibleClip As Integer
        Dim iTotalClip As Integer

        iFirstClip = AxImageThumbnailCP1.CurrentVisibleFirstClipIndex

        iTotalVisibleClip = AxImageThumbnailCP1.CurrentVisibleClipCount

        iTotalClip = iFirstClip + iTotalVisibleClip - 1

        For i = iFirstClip To iTotalClip
            MessageBox.Show(AxImageThumbnailCP1.GetClipFilePath(i))
        Next

    End Sub

    Private Sub AxImageThumbnailCP1_OnDropFiles(ByVal sender As System.Object, ByVal e As AxIMAGETHUMBNAILCPLib._DImageThumbnailCPEvents_OnDropFilesEvent)

    End Sub

    Private Sub MyThubnailClick(ByVal iClipIndex As Short, ByVal strFilePath As String, ByVal iPageNo As Short)


        txtCurrentIndex.Text = iClipIndex

        txtFileName.Text = strFilePath


        txtPageNo.Text = iPageNo


        AxImageThumbnailCP1.Focus()
    End Sub
    Private Sub AxImageThumbnailCP1_ClickEvent(ByVal sender As Object, ByVal e As AxIMAGETHUMBNAILCPLib._DImageThumbnailCPEvents_ClickEvent) Handles AxImageThumbnailCP1.ClickEvent
        MyThubnailClick(e.iClipIndex, e.strFilePath, e.iPageNo)

    End Sub

    Private Sub AxImageThumbnailCP1_LeftPress(ByVal sender As Object, ByVal e As AxIMAGETHUMBNAILCPLib._DImageThumbnailCPEvents_LeftPressEvent)
        txtCurrentIndex.Text = e.iClipIndex
        txtFileName.Text = e.strFilePath
        txtPageNo.Text = e.iPageNo
        If e.iClipIndex Mod 3 = 0 Then
            Me.AxImageThumbnailCP1.VScroll(0)
        End If
        AxImageThumbnailCP1.Focus()
    End Sub

    Private Sub AxImageThumbnailCP1_RightClick(ByVal sender As Object, ByVal e As AxIMAGETHUMBNAILCPLib._DImageThumbnailCPEvents_RightClickEvent)
        txtCurrentIndex.Text = e.iClipIndex
        txtFileName.Text = e.strFilePath
        txtPageNo.Text = e.iPageNo
        If e.iClipIndex Mod 3 = 0 Then
            Me.AxImageThumbnailCP1.VScroll(1)
        End If
        AxImageThumbnailCP1.Focus()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub AxImageThumbnailCP1_OnDropFiles_1(ByVal sender As System.Object, ByVal e As AxIMAGETHUMBNAILCPLib._DImageThumbnailCPEvents_OnDropFilesEvent) Handles AxImageThumbnailCP1.OnDropFiles































        '















    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim strPDFProperty As String
        Dim iCurIndex As Integer

        iCurIndex = AxImageThumbnailCP1.GetCurSel

        strPDFProperty = "PDF Resolution:" + Str(Me.AxImageThumbnailCP1.GetClipPDFWidth(iCurIndex)) + "x" + Str(Me.AxImageThumbnailCP1.GetClipPDFHeight(iCurIndex)) + Chr(13) + Chr(10)
        strPDFProperty = strPDFProperty + "PDF Title:" + Me.AxImageThumbnailCP1.GetClipPDFTitle(iCurIndex) + Chr(13) + Chr(10)
        strPDFProperty = strPDFProperty + "PDF Subject:" + Me.AxImageThumbnailCP1.GetClipPDFSubject(iCurIndex) + Chr(13) + Chr(10)
        strPDFProperty = strPDFProperty + "PDF Author:" + Me.AxImageThumbnailCP1.GetClipPDFAuthor(iCurIndex) + Chr(13) + Chr(10)
        strPDFProperty = strPDFProperty + "PDF Creation Date:" + Me.AxImageThumbnailCP1.GetClipPDFCreationDate(iCurIndex) + Chr(13) + Chr(10)
        strPDFProperty = strPDFProperty + "PDF Modify Date:" + Me.AxImageThumbnailCP1.GetClipPDFModifyDate(iCurIndex) + Chr(13) + Chr(10)
        strPDFProperty = strPDFProperty + "PDF Version No:" + Str(Me.AxImageThumbnailCP1.GetClipPDFVersionNo(iCurIndex)) + Chr(13) + Chr(10)
        strPDFProperty = strPDFProperty + "PDF Keyword:" + Me.AxImageThumbnailCP1.GetClipPDFKeyword(iCurIndex) + Chr(13) + Chr(10)
        strPDFProperty = strPDFProperty + "Total Page:" + Str(Me.AxImageThumbnailCP1.GetClipPDFTotalPage(iCurIndex)) + Chr(13) + Chr(10)

        MessageBox.Show(strPDFProperty)
    End Sub
End Class

