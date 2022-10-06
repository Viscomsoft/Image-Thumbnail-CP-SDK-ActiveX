VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Object = "{C08027D6-71EE-4936-AC1F-3F188E8889A3}#1.0#0"; "ImageThumbnailCP.ocx"
Begin VB.Form Form1 
   Caption         =   "Image Thumbnail CP ActiveX Control"
   ClientHeight    =   9990
   ClientLeft      =   165
   ClientTop       =   555
   ClientWidth     =   14115
   LinkTopic       =   "Form1"
   ScaleHeight     =   9990
   ScaleWidth      =   14115
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command29 
      Caption         =   "Get PDF Information"
      Height          =   375
      Left            =   10920
      TabIndex        =   66
      Top             =   5280
      Width           =   1815
   End
   Begin IMAGETHUMBNAILCPLib.ImageThumbnailCP ImageThumbnailCP1 
      Height          =   5415
      Left            =   3120
      TabIndex        =   65
      Top             =   480
      Width           =   7215
      _Version        =   65536
      _ExtentX        =   12726
      _ExtentY        =   9551
      _StockProps     =   0
      BackgroundColor =   0
   End
   Begin VB.Frame Frame2 
      Caption         =   "Filter"
      Height          =   1335
      Left            =   120
      TabIndex        =   61
      Top             =   2880
      Width           =   2535
      Begin VB.ComboBox cbofilter 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Left            =   120
         Style           =   2  'Dropdown List
         TabIndex        =   63
         Top             =   240
         Width           =   2295
      End
      Begin VB.CommandButton Command22 
         Caption         =   "Add File From Folder"
         Height          =   375
         Left            =   120
         TabIndex        =   62
         Top             =   840
         Width           =   2175
      End
   End
   Begin VB.TextBox txtPageNo 
      Height          =   375
      Left            =   9120
      TabIndex        =   60
      Text            =   "1"
      Top             =   6720
      Width           =   975
   End
   Begin VB.CommandButton Command27 
      Caption         =   "visible clips"
      Height          =   495
      Left            =   10920
      TabIndex        =   59
      Top             =   8640
      Width           =   1815
   End
   Begin VB.CommandButton Command26 
      Caption         =   "UnSelect Multiple Clips"
      Height          =   375
      Left            =   10920
      TabIndex        =   58
      Top             =   8040
      Width           =   1815
   End
   Begin VB.CommandButton Command25 
      Caption         =   "Select Multiple Clips"
      Height          =   375
      Left            =   10920
      TabIndex        =   57
      Top             =   7560
      Width           =   1815
   End
   Begin VB.CommandButton Command24 
      Caption         =   "Select One Clip"
      Height          =   375
      Left            =   10920
      TabIndex        =   56
      Top             =   7080
      Width           =   1815
   End
   Begin VB.CommandButton Command23 
      Caption         =   "Rotate"
      Height          =   255
      Left            =   10920
      TabIndex        =   55
      Top             =   6600
      Width           =   1095
   End
   Begin VB.ComboBox cborotate 
      Height          =   315
      Left            =   10920
      Style           =   2  'Dropdown List
      TabIndex        =   54
      Top             =   6120
      Width           =   3015
   End
   Begin VB.CommandButton Command21 
      Caption         =   "Scroll one line down"
      Height          =   375
      Left            =   120
      TabIndex        =   52
      Top             =   1680
      Width           =   1695
   End
   Begin VB.CommandButton Command20 
      Caption         =   "Scroll one line up"
      Height          =   375
      Left            =   120
      TabIndex        =   51
      Top             =   1200
      Width           =   1695
   End
   Begin VB.ComboBox cbodisplaymode 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   120
      Style           =   2  'Dropdown List
      TabIndex        =   48
      Top             =   2520
      Width           =   2415
   End
   Begin VB.ComboBox cboscrollbar 
      Height          =   315
      Left            =   1440
      Style           =   2  'Dropdown List
      TabIndex        =   46
      Top             =   360
      Width           =   1215
   End
   Begin VB.CommandButton Command19 
      Caption         =   "Set"
      Height          =   375
      Left            =   13080
      TabIndex        =   44
      Top             =   2760
      Width           =   495
   End
   Begin VB.CommandButton Command18 
      Caption         =   "Set"
      Height          =   372
      Left            =   13080
      TabIndex        =   43
      Top             =   240
      Width           =   495
   End
   Begin VB.Frame Frame1 
      Caption         =   "You can display specific images for specific files"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3015
      Left            =   2640
      TabIndex        =   37
      Top             =   7320
      Width           =   8175
      Begin VB.TextBox txtFileExt 
         Height          =   375
         Left            =   3840
         TabIndex        =   41
         Top             =   360
         Width           =   1095
      End
      Begin VB.CommandButton cmddelcustom 
         Caption         =   "Delete file type"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   5640
         TabIndex        =   40
         Top             =   1440
         Width           =   2415
      End
      Begin VB.CommandButton cmdaddcustom 
         Caption         =   "Add file type"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   5640
         TabIndex        =   39
         Top             =   960
         Width           =   2415
      End
      Begin VB.ListBox List1 
         Columns         =   1
         Height          =   1815
         Left            =   240
         TabIndex        =   38
         Top             =   960
         Width           =   5295
      End
      Begin VB.Label Label11 
         Caption         =   "Input File extension e.g.(ppt)"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   240
         TabIndex        =   42
         Top             =   360
         Width           =   3015
      End
   End
   Begin MSComDlg.CommonDialog CommonDialog2 
      Left            =   12120
      Top             =   6360
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton Command17 
      Caption         =   "Normal Style"
      Height          =   372
      Left            =   120
      TabIndex        =   36
      Top             =   8520
      Width           =   2415
   End
   Begin VB.CommandButton Command14 
      Caption         =   "ACDSee Style"
      Height          =   375
      Left            =   120
      TabIndex        =   35
      Top             =   8040
      Width           =   2415
   End
   Begin VB.CommandButton Command16 
      Caption         =   "Set"
      Height          =   375
      Left            =   13080
      TabIndex        =   31
      Top             =   1800
      Width           =   495
   End
   Begin VB.TextBox txtFontTop 
      Height          =   372
      Left            =   12360
      TabIndex        =   30
      Text            =   "0"
      Top             =   1800
      Width           =   615
   End
   Begin VB.TextBox txtTopMargin 
      Height          =   372
      Left            =   12360
      TabIndex        =   29
      Text            =   "0"
      Top             =   240
      Width           =   615
   End
   Begin VB.TextBox txtBottomMargin 
      Height          =   372
      Left            =   12360
      TabIndex        =   28
      Text            =   "0"
      Top             =   720
      Width           =   615
   End
   Begin VB.CommandButton Command13 
      Caption         =   "Set"
      Height          =   372
      Left            =   13080
      TabIndex        =   27
      Top             =   720
      Width           =   495
   End
   Begin VB.CommandButton Command12 
      Caption         =   "Set"
      Height          =   375
      Left            =   13080
      TabIndex        =   26
      Top             =   2280
      Width           =   495
   End
   Begin VB.TextBox txtHeight 
      Height          =   375
      Left            =   12360
      TabIndex        =   25
      Text            =   "60"
      Top             =   2760
      Width           =   615
   End
   Begin VB.TextBox txtWidth 
      Height          =   375
      Left            =   12360
      TabIndex        =   23
      Text            =   "60"
      Top             =   2280
      Width           =   615
   End
   Begin VB.CommandButton Command15 
      Caption         =   "Set"
      Height          =   375
      Left            =   13080
      TabIndex        =   21
      Top             =   1200
      Width           =   495
   End
   Begin VB.TextBox txtFontSize 
      Height          =   375
      Left            =   12360
      TabIndex        =   20
      Text            =   "8"
      Top             =   1200
      Width           =   615
   End
   Begin VB.CommandButton Command11 
      Caption         =   "Display Selected FileName"
      Height          =   375
      Left            =   120
      TabIndex        =   18
      Top             =   9960
      Width           =   2415
   End
   Begin VB.CommandButton Command10 
      Caption         =   "Delete Selected Clip"
      Height          =   375
      Left            =   120
      TabIndex        =   17
      Top             =   9480
      Width           =   2415
   End
   Begin VB.CommandButton Command9 
      Caption         =   "Delete All"
      Height          =   375
      Left            =   120
      TabIndex        =   16
      Top             =   9000
      Width           =   2415
   End
   Begin VB.CheckBox Check3 
      Caption         =   "Clip Font Underline"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   10920
      TabIndex        =   15
      Top             =   4800
      Width           =   2415
   End
   Begin VB.CheckBox Check2 
      Caption         =   "Clip Font Italic"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   10920
      TabIndex        =   14
      Top             =   4440
      Width           =   1815
   End
   Begin VB.CheckBox Check1 
      Caption         =   "Clip Font Bold"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   10920
      TabIndex        =   13
      Top             =   4080
      Width           =   1815
   End
   Begin VB.CommandButton Command8 
      Caption         =   "Update Caption Text"
      Height          =   375
      Left            =   120
      TabIndex        =   12
      Top             =   7560
      Width           =   2415
   End
   Begin VB.CommandButton Command7 
      Caption         =   "Text Color"
      Height          =   375
      Left            =   120
      TabIndex        =   11
      Top             =   7080
      Width           =   2415
   End
   Begin VB.CommandButton Command6 
      Caption         =   "Shadow Color"
      Height          =   375
      Left            =   120
      TabIndex        =   9
      Top             =   6600
      Width           =   2415
   End
   Begin VB.CommandButton Command5 
      Caption         =   "Border color"
      Height          =   375
      Left            =   120
      TabIndex        =   8
      Top             =   6120
      Width           =   2415
   End
   Begin VB.CommandButton Command4 
      Caption         =   "Highlight color"
      Height          =   375
      Left            =   120
      TabIndex        =   7
      Top             =   5640
      Width           =   2415
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Clip Color"
      Height          =   375
      Left            =   120
      TabIndex        =   6
      Top             =   5160
      Width           =   2415
   End
   Begin VB.TextBox txt_filename 
      Height          =   375
      Left            =   4200
      TabIndex        =   5
      Top             =   6240
      Width           =   3255
   End
   Begin VB.TextBox txt_curIndex 
      Height          =   375
      Left            =   9120
      TabIndex        =   3
      Text            =   "0"
      Top             =   6240
      Width           =   612
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Add File"
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   4200
      Width           =   2415
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Background Color"
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   4680
      Width           =   2415
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   12600
      Top             =   6480
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Label Label16 
      Caption         =   "Page No"
      Height          =   375
      Left            =   7800
      TabIndex        =   64
      Top             =   6840
      Width           =   1215
   End
   Begin VB.Label Label15 
      Caption         =   "Rotate Type"
      Height          =   255
      Left            =   10920
      TabIndex        =   53
      Top             =   5760
      Width           =   1095
   End
   Begin VB.Label Label14 
      Caption         =   "Programmatically Scrolling"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   50
      Top             =   840
      Width           =   2295
   End
   Begin VB.Label Label13 
      Caption         =   "If the clip size is big, you should use high Display Mode property"
      Height          =   495
      Left            =   11160
      TabIndex        =   49
      Top             =   3480
      Width           =   2655
   End
   Begin VB.Label Label12 
      Caption         =   "Display Mode"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   47
      Top             =   2160
      Width           =   975
   End
   Begin VB.Label Label10 
      Caption         =   "ScrollBar Type"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   45
      Top             =   360
      Width           =   1215
   End
   Begin VB.Label Label9 
      Caption         =   "Bottom Margin"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   11040
      TabIndex        =   34
      Top             =   720
      Width           =   1335
   End
   Begin VB.Label Label8 
      Caption         =   "Top Margin"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   11040
      TabIndex        =   33
      Top             =   240
      Width           =   1335
   End
   Begin VB.Label Label7 
      Caption         =   "Font Top"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   11040
      TabIndex        =   32
      Top             =   1800
      Width           =   1095
   End
   Begin VB.Label Label6 
      Caption         =   "Clip Height"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   11040
      TabIndex        =   24
      Top             =   2760
      Width           =   975
   End
   Begin VB.Label Label5 
      Caption         =   "Clip Width"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   11040
      TabIndex        =   22
      Top             =   2280
      Width           =   975
   End
   Begin VB.Label Label4 
      Caption         =   "Font Size"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   11040
      TabIndex        =   19
      Top             =   1200
      Width           =   1095
   End
   Begin VB.Label Label3 
      Caption         =   "Accept Drop Files and you can drag the image to reorder the thumbnail"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2880
      TabIndex        =   10
      Top             =   0
      Width           =   7695
   End
   Begin VB.Label Label2 
      Caption         =   "File Name"
      Height          =   375
      Left            =   2880
      TabIndex        =   4
      Top             =   6240
      Width           =   975
   End
   Begin VB.Label Label1 
      Caption         =   "Current Index"
      Height          =   375
      Left            =   7800
      TabIndex        =   2
      Top             =   6240
      Width           =   1095
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim oldBackcolor
Dim oldBorderColor
Dim oldShadowColor
Dim oldClipColor



 


Private Sub cbodisplaymode_Click()


  
 ImageThumbnailCP1.DisplayMode = cbodisplaymode.ListIndex
        

End Sub

Private Sub cboscrollbar_Click()
If cboscrollbar.ListIndex = 0 Then
       
        ImageThumbnailCP1.ScrollBarType = 0
         ImageThumbnailCP1.Height = 5655
Else
      
        ImageThumbnailCP1.ScrollBarType = 1
        ImageThumbnailCP1.Height = 2200

        
End If

ImageThumbnailCP1.Refresh
End Sub

Private Sub Check1_Click()

If Me.Check1 = 1 Then
    
    Me.ImageThumbnailCP1.ClipFontBold = True
Else
    Me.ImageThumbnailCP1.ClipFontBold = False

End If
 Me.ImageThumbnailCP1.SetFocus

End Sub

Private Sub Check2_Click()
If Me.Check2 = 1 Then
    
    Me.ImageThumbnailCP1.ClipFontItalic = True
Else
    Me.ImageThumbnailCP1.ClipFontItalic = False

End If

 Me.ImageThumbnailCP1.SetFocus
End Sub

Private Sub Check3_Click()

If Me.Check3 = 1 Then
    
    Me.ImageThumbnailCP1.ClipFontUnderline = True
Else
    Me.ImageThumbnailCP1.ClipFontUnderline = False

End If

 Me.ImageThumbnailCP1.SetFocus
End Sub

Private Sub cmdaddcustom_Click()

If txtFileExt = "" Then
    MsgBox "please input file extension"
    Exit Sub
End If


CommonDialog2.DialogTitle = "Select the image file"
CommonDialog2.Filter = "JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|Gif (*.gif)|*.gif|Icon (*.ico)|*.ico"
CommonDialog2.ShowOpen
List1.AddItem txtFileExt
ImageThumbnailCP1.AddCustomType Trim(txtFileExt), CommonDialog2.FileName
txtFileExt = ""
End Sub

Private Sub cmddelcustom_Click()

If List1.ListIndex = -1 Then
    MsgBox "Please select the list box first"
    Exit Sub
End If




If ImageThumbnailCP1.RemoveCustomType(Trim(List1.List(List1.ListIndex))) Then
    List1.RemoveItem (List1.ListIndex)
Else
    MsgBox "cannot find this extension"
End If

End Sub

Private Sub Command1_Click()
CommonDialog1.ShowColor

 Me.ImageThumbnailCP1.BackgroundColor = CommonDialog1.Color
 Me.ImageThumbnailCP1.SetFocus
End Sub

Private Sub Command10_Click()

Me.ImageThumbnailCP1.DeleteSelectedClip
 Me.ImageThumbnailCP1.SetFocus

End Sub

Private Sub Command11_Click()


For i = 0 To Me.ImageThumbnailCP1.ClipCount

    If ImageThumbnailCP1.GetSelect(i) Then
            
            MsgBox ImageThumbnailCP1.GetClipFilePath(i)
    End If
    
    
    
Next


End Sub

Private Sub Command12_Click()

If txtWidth < 60 Or txtHeight < 60 Then
    MsgBox "the value cannot smaller than 60"
    Exit Sub
    
End If


Me.ImageThumbnailCP1.ClipWidth = Me.txtWidth
Me.ImageThumbnailCP1.ClipHeight = Me.txtHeight
End Sub


Private Sub Command14_Click()
ImageThumbnailCP1.BackgroundColor = RGB(128, 128, 128)
ImageThumbnailCP1.ClipBorderColor = RGB(128, 128, 128)
ImageThumbnailCP1.ClipShadowColor = RGB(128, 128, 128)
ImageThumbnailCP1.ClipColor = RGB(128, 128, 128)
ImageThumbnailCP1.ClipFontSize = 10
ImageThumbnailCP1.ClipFontName = 12
ImageThumbnailCP1.ClipFontTopPos = 95
ImageThumbnailCP1.ClipTopMargin = 0
ImageThumbnailCP1.ClipBottomMargin = 15
ImageThumbnailCP1.ClipWidth = 110
ImageThumbnailCP1.ClipHeight = 120


icount = ImageThumbnailCP1.ClipCount

For i = 0 To icount

    ImageThumbnailCP1.SetClipInfo i, "", " Demo " + Trim(Str(i))
Next

 ImageThumbnailCP1.SetFocus


End Sub

Private Sub Command13_Click()
ImageThumbnailCP1.ClipTopMargin = Val(txtTopMargin)
ImageThumbnailCP1.ClipBottomMargin = Val(txtBottomMargin)

End Sub

Private Sub Command15_Click()
  Me.ImageThumbnailCP1.ClipFontSize = Val(txtFontSize.Text)
End Sub

Private Sub Command16_Click()
Me.ImageThumbnailCP1.ClipFontTopPos = Val(txtFontTop)
End Sub

Private Sub Command17_Click()


 Me.ImageThumbnailCP1.BackgroundColor = oldBackcolor
 Me.ImageThumbnailCP1.ClipBorderColor = oldBorderColor

 Me.ImageThumbnailCP1.ClipShadowColor = oldShadowColor
 Me.ImageThumbnailCP1.ClipColor = oldClipColor


End Sub


Private Sub Command19_Click()
If txtWidth < 60 Or txtHeight < 60 Then
    MsgBox "the value cannot smaller than 60"
    Exit Sub
    
End If


Me.ImageThumbnailCP1.ClipWidth = Me.txtWidth
Me.ImageThumbnailCP1.ClipHeight = Me.txtHeight

End Sub

Private Sub Command18_Click()
ImageThumbnailCP1.ClipTopMargin = Val(txtTopMargin)
ImageThumbnailCP1.ClipBottomMargin = Val(txtBottomMargin)

End Sub

Private Sub Command2_Click()
Me.CommonDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"


Me.CommonDialog1.ShowOpen



Me.ImageThumbnailCP1.AddClip CommonDialog1.FileName, ""
ImageThumbnailCP1.UnSelectAllClip
ImageThumbnailCP1.SelectClip (ImageThumbnailCP1.ClipCount - 1)
ImageThumbnailCP1.VScroll 7

ImageThumbnailCP1.SetFocus


End Sub

Private Sub Command20_Click()

If cboscrollbar.ListIndex = 0 Then
    ImageThumbnailCP1.VScroll 0
Else
    ImageThumbnailCP1.HScroll 0
End If


End Sub

Private Sub Command21_Click()
If cboscrollbar.ListIndex = 0 Then
    ImageThumbnailCP1.VScroll 1
Else
    ImageThumbnailCP1.HScroll 1
End If

End Sub

Private Sub Command22_Click()


strPath = Me.ImageThumbnailCP1.BrowseFolder("Please select folder")


 

Select Case cbofilter.ListIndex

Case 0
   Me.ImageThumbnailCP1.AddClipsFromFolder strPath, "jpg|bmp|gif|png"
Case 1
   Me.ImageThumbnailCP1.AddClipsFromFolder strPath, "jpg|bmp|gif|png|psd|tif"
Case 2
   Me.ImageThumbnailCP1.AddClipsFromFolder strPath, "pdf|tif"
Case 3
   Me.ImageThumbnailCP1.AddClipsFromFolder strPath, "psd|pdf|tif|pcx|png|gif|tga|wbmp|wmf|j2k|jp2|j2c|pgx|ras|pmn|ico|bmp|jpg|png"
End Select




End Sub

Private Sub Command23_Click()

For i = 0 To Me.ImageThumbnailCP1.ClipCount

    If ImageThumbnailCP1.GetSelect(i) Then
            
        Me.ImageThumbnailCP1.Rotate i, cborotate.ListIndex
    End If
    
    
    
Next

End Sub

Private Sub Command24_Click()

Me.ImageThumbnailCP1.UnSelectAllClip
Me.ImageThumbnailCP1.SelectClip 0

End Sub

Private Sub Command25_Click()
Me.ImageThumbnailCP1.UnSelectAllClip

Me.ImageThumbnailCP1.SelectClip 1
Me.ImageThumbnailCP1.SelectClip 2
Me.ImageThumbnailCP1.SelectClip 3


End Sub

Private Sub Command26_Click()
Me.ImageThumbnailCP1.UnSelectClip 1
Me.ImageThumbnailCP1.UnSelectClip 2
Me.ImageThumbnailCP1.UnSelectClip 3


End Sub

Private Sub Command27_Click()
Dim iFirstClip As Integer
 
iFirstClip = Me.ImageThumbnailCP1.CurrentVisibleFirstClipIndex
 
iTotalVisibleClip = Me.ImageThumbnailCP1.CurrentVisibleClipCount
 
 

            
            
TotalClip = iFirstClip + iTotalVisibleClip - 1

For i = iFirstClip To TotalClip
 MsgBox ImageThumbnailCP1.GetClipFilePath(i)
Next

End Sub

Private Sub Command28_Click()


End Sub

Private Sub Command29_Click()
Dim strPDFProperty As String

iCurIndex = Me.ImageThumbnailCP1.GetCurSel

strPDFProperty = "PDF Resolution:" + Str(Me.ImageThumbnailCP1.GetClipPDFWidth(iCurIndex)) + "x" + Str(Me.ImageThumbnailCP1.GetClipPDFHeight(iCurIndex)) + Chr(13) + Chr(10)
strPDFProperty = strPDFProperty + "PDF Title:" + Me.ImageThumbnailCP1.GetClipPDFTitle(iCurIndex) + Chr(13) + Chr(10)
strPDFProperty = strPDFProperty + "PDF Subject:" + Me.ImageThumbnailCP1.GetClipPDFSubject(iCurIndex) + Chr(13) + Chr(10)
strPDFProperty = strPDFProperty + "PDF Author:" + Me.ImageThumbnailCP1.GetClipPDFAuthor(iCurIndex) + Chr(13) + Chr(10)
strPDFProperty = strPDFProperty + "PDF Creation Date:" + Me.ImageThumbnailCP1.GetClipPDFCreationDate(iCurIndex) + Chr(13) + Chr(10)
strPDFProperty = strPDFProperty + "PDF Modify Date:" + Me.ImageThumbnailCP1.GetClipPDFModifyDate(iCurIndex) + Chr(13) + Chr(10)
strPDFProperty = strPDFProperty + "PDF Version No:" + Str(Me.ImageThumbnailCP1.GetClipPDFVersionNo(iCurIndex)) + Chr(13) + Chr(10)
strPDFProperty = strPDFProperty + "PDF Keyword:" + Me.ImageThumbnailCP1.GetClipPDFKeyword(iCurIndex) + Chr(13) + Chr(10)
strPDFProperty = strPDFProperty + "Total Page:" + Str(Me.ImageThumbnailCP1.GetClipPDFTotalPage(iCurIndex)) + Chr(13) + Chr(10)









MsgBox strPDFProperty
End Sub

Private Sub Command3_Click()
 CommonDialog1.ShowColor

 Me.ImageThumbnailCP1.ClipColor = CommonDialog1.Color
 Me.ImageThumbnailCP1.SetFocus

 Me.ImageThumbnailCP1.SetFocus
End Sub

Private Sub Command4_Click()
 CommonDialog1.ShowColor

 Me.ImageThumbnailCP1.ClipHighlightColor = CommonDialog1.Color
 Me.ImageThumbnailCP1.SetFocus

End Sub

Private Sub Command5_Click()
 CommonDialog1.ShowColor

 Me.ImageThumbnailCP1.ClipBorderColor = CommonDialog1.Color
 Me.ImageThumbnailCP1.SetFocus



End Sub

Private Sub Command6_Click()
 CommonDialog1.ShowColor

 Me.ImageThumbnailCP1.ClipShadowColor = CommonDialog1.Color
 Me.ImageThumbnailCP1.SetFocus


End Sub

Private Sub Command7_Click()
 
 CommonDialog1.ShowColor
 Me.ImageThumbnailCP1.ClipTextColor = CommonDialog1.Color
 Me.ImageThumbnailCP1.SetFocus


End Sub

Private Sub Command8_Click()

icount = ImageThumbnailCP1.ClipCount

For i = 0 To icount

    Me.ImageThumbnailCP1.SetClipInfo i, "", " Demo " + Trim(Str(i))
Next

 Me.ImageThumbnailCP1.SetFocus
End Sub

Private Sub Command9_Click()

ImageThumbnailCP1.DeleteAllClips
 
 Me.ImageThumbnailCP1.SetFocus

End Sub

Private Sub Form_Load()

cbofilter.AddItem "JPG|BMP|GIF|PNG"
cbofilter.AddItem "JPG|BMP|GIF|PNG|PSD|TIF"
cbofilter.AddItem "PDF|TIF"
cbofilter.AddItem "All Supported Image formats"
cbofilter.ListIndex = 0

oldBackcolor = Me.ImageThumbnailCP1.BackgroundColor
oldBorderColor = Me.ImageThumbnailCP1.ClipBorderColor

oldShadowColor = Me.ImageThumbnailCP1.ClipShadowColor
oldClipColor = Me.ImageThumbnailCP1.ClipColor


cboscrollbar.AddItem "Vertical"
cboscrollbar.AddItem "Horizontal"
cboscrollbar.ListIndex = 0

cbodisplaymode.AddItem "Fast Speed, poor Quality"
cbodisplaymode.AddItem "Normal Speed, Normal Quality"
cbodisplaymode.AddItem "Slow Speed, High Quality"
cbodisplaymode.AddItem "Very Slow Speed, Best Quality "
cbodisplaymode.ListIndex = 1


cborotate.AddItem "No Rotate"
cborotate.AddItem "Rotate90FlipNone"
cborotate.AddItem "Rotate180FlipNone"
cborotate.AddItem "Rotate270FlipNone"
cborotate.AddItem "RotateNoneFlipX"
cborotate.AddItem "Rotate90FlipX"
cborotate.AddItem "Rotate180FlipX"
cborotate.AddItem "Rotate270FlipX"
cborotate.AddItem "RotateNoneFlipY"
cborotate.AddItem "Rotate90FlipY"
cborotate.AddItem "Rotate180FlipY"
cborotate.AddItem "Rotate270FlipY"
cborotate.ListIndex = 0










End Sub





Private Sub ImageThumbnailCP1_Click(iClipIndex As Integer, strFilePath As String, iPageNo As Integer)
txt_curIndex = Str(iClipIndex)
txt_filename = strFilePath
txtPageNo = iPageNo
ImageThumbnailCP1.SetFocus


End Sub

Private Sub ImageThumbnailCP1_DblClick(iClipIndex As Integer, strFilePath As String, iPageNo As Integer)
txtPageNo = iPageNo
End Sub


Private Sub ImageThumbnailCP1_LeftPress(ByVal iClipIndex As Integer, ByVal strFilePath As String, ByVal iPageNo As Integer)
txt_curIndex = Str(iClipIndex)
txt_filename = strFilePath
txtPageNo = iPageNo
If iClipIndex Mod 3 = 0 Then
        Me.ImageThumbnailCP1.VScroll 0
      
End If

Me.ImageThumbnailCP1.SetFocus


End Sub

Private Sub ImageThumbnailCP1_OnDropFiles(ByVal iFileCount As Integer)
ImageThumbnailCP1.SelectClip (ImageThumbnailCP1.ClipCount - 1)
ImageThumbnailCP1.VScroll 7
ImageThumbnailCP1.SetFocus

End Sub


Private Sub ImageThumbnailCP1_RightPress(ByVal iClipIndex As Integer, ByVal strFilePath As String, ByVal iPageNo As Integer)
txt_curIndex = Str(iClipIndex)
txt_filename = strFilePath
txtPageNo = iPageNo

If iClipIndex Mod 3 = 0 Then
        Me.ImageThumbnailCP1.VScroll 1
      
End If

Me.ImageThumbnailCP1.SetFocus
End Sub
