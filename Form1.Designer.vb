<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btn_entrar = New Guna.UI2.WinForms.Guna2Button()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        txt_senha = New Guna.UI2.WinForms.Guna2TextBox()
        txt_usuario = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        LinkLabel1 = New LinkLabel()
        Guna2Transition2 = New Guna.UI2.WinForms.Guna2Transition()
        Guna2GradientPanel1.SuspendLayout()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_entrar
        ' 
        btn_entrar.Animated = True
        btn_entrar.AnimatedGIF = True
        btn_entrar.AutoRoundedCorners = True
        btn_entrar.BackColor = Color.Transparent
        btn_entrar.BorderStyle = Drawing2D.DashStyle.Dash
        btn_entrar.CustomizableEdges = CustomizableEdges1
        Guna2Transition2.SetDecoration(btn_entrar, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2Transition1.SetDecoration(btn_entrar, Guna.UI2.AnimatorNS.DecorationType.None)
        btn_entrar.DisabledState.BorderColor = Color.DarkGray
        btn_entrar.DisabledState.CustomBorderColor = Color.DarkGray
        btn_entrar.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_entrar.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_entrar.FillColor = Color.FromArgb(CByte(23), CByte(184), CByte(196))
        btn_entrar.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn_entrar.ForeColor = Color.White
        btn_entrar.Location = New Point(374, 283)
        btn_entrar.Margin = New Padding(2)
        btn_entrar.Name = "btn_entrar"
        btn_entrar.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btn_entrar.Size = New Size(141, 48)
        btn_entrar.TabIndex = 8
        btn_entrar.Text = "Entrar"
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.AnimateWindow = True
        Guna2BorderlessForm1.BorderRadius = 30
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' txt_senha
        ' 
        txt_senha.BackColor = Color.Transparent
        txt_senha.BorderRadius = 25
        txt_senha.CustomizableEdges = CustomizableEdges11
        Guna2Transition2.SetDecoration(txt_senha, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2Transition1.SetDecoration(txt_senha, Guna.UI2.AnimatorNS.DecorationType.None)
        txt_senha.DefaultText = ""
        txt_senha.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_senha.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_senha.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_senha.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_senha.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_senha.Font = New Font("Segoe UI", 9F)
        txt_senha.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_senha.IconLeft = CType(resources.GetObject("txt_senha.IconLeft"), Image)
        txt_senha.IconLeftOffset = New Point(10, 0)
        txt_senha.IconLeftSize = New Size(30, 30)
        txt_senha.Location = New Point(304, 208)
        txt_senha.Name = "txt_senha"
        txt_senha.PasswordChar = "*"c
        txt_senha.PlaceholderText = "Senha"
        txt_senha.SelectedText = ""
        txt_senha.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        txt_senha.Size = New Size(281, 29)
        txt_senha.TabIndex = 9
        ' 
        ' txt_usuario
        ' 
        txt_usuario.BackColor = Color.Transparent
        txt_usuario.BorderRadius = 25
        txt_usuario.CustomizableEdges = CustomizableEdges9
        Guna2Transition2.SetDecoration(txt_usuario, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2Transition1.SetDecoration(txt_usuario, Guna.UI2.AnimatorNS.DecorationType.None)
        txt_usuario.DefaultText = ""
        txt_usuario.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_usuario.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_usuario.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_usuario.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_usuario.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_usuario.Font = New Font("Segoe UI", 9F)
        txt_usuario.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_usuario.IconLeft = CType(resources.GetObject("txt_usuario.IconLeft"), Image)
        txt_usuario.IconLeftOffset = New Point(10, 0)
        txt_usuario.IconLeftSize = New Size(30, 30)
        txt_usuario.Location = New Point(304, 160)
        txt_usuario.Name = "txt_usuario"
        txt_usuario.PlaceholderText = "Usuario"
        txt_usuario.SelectedText = ""
        txt_usuario.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txt_usuario.Size = New Size(281, 29)
        txt_usuario.TabIndex = 10
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.Controls.Add(Guna2PictureBox1)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges7
        Guna2Transition1.SetDecoration(Guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2Transition2.SetDecoration(Guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2GradientPanel1.FillColor = Color.FromArgb(CByte(10), CByte(61), CByte(102))
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(23), CByte(184), CByte(196))
        Guna2GradientPanel1.Location = New Point(-8, -5)
        Guna2GradientPanel1.Margin = New Padding(2)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2GradientPanel1.Size = New Size(290, 402)
        Guna2GradientPanel1.TabIndex = 11
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.BackColor = Color.Transparent
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges5
        Guna2Transition2.SetDecoration(Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2Transition1.SetDecoration(Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), Image)
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(-76, 2)
        Guna2PictureBox1.Margin = New Padding(2)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2PictureBox1.Size = New Size(463, 273)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        Guna2PictureBox1.UseTransparentBackground = True
        ' 
        ' Guna2PictureBox2
        ' 
        Guna2PictureBox2.CustomizableEdges = CustomizableEdges3
        Guna2Transition2.SetDecoration(Guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2Transition1.SetDecoration(Guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), Image)
        Guna2PictureBox2.ImageRotate = 0F
        Guna2PictureBox2.Location = New Point(391, 41)
        Guna2PictureBox2.Margin = New Padding(2)
        Guna2PictureBox2.Name = "Guna2PictureBox2"
        Guna2PictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2PictureBox2.Size = New Size(99, 89)
        Guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2PictureBox2.TabIndex = 12
        Guna2PictureBox2.TabStop = False
        ' 
        ' Guna2Transition1
        ' 
        Guna2Transition1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), PointF)
        Animation2.LeafCoeff = 0F
        Animation2.MaxTime = 1F
        Animation2.MinTime = 0F
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New Padding(0)
        Animation2.RotateCoeff = 0F
        Animation2.RotateLimit = 0F
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), PointF)
        Animation2.TimeCoeff = 0F
        Animation2.TransparencyCoeff = 0F
        Guna2Transition1.DefaultAnimation = Animation2
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        Guna2Transition1.SetDecoration(LinkLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2Transition2.SetDecoration(LinkLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        LinkLabel1.LinkColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        LinkLabel1.Location = New Point(480, 247)
        LinkLabel1.Margin = New Padding(2, 0, 2, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(98, 15)
        LinkLabel1.TabIndex = 14
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Esquece a senha?"
        ' 
        ' Guna2Transition2
        ' 
        Guna2Transition2.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), PointF)
        Animation1.LeafCoeff = 0F
        Animation1.MaxTime = 1F
        Animation1.MinTime = 0F
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New Padding(0)
        Animation1.RotateCoeff = 0F
        Animation1.RotateLimit = 0F
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), PointF)
        Animation1.TimeCoeff = 0F
        Animation1.TransparencyCoeff = 0F
        Guna2Transition2.DefaultAnimation = Animation1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(621, 383)
        Controls.Add(LinkLabel1)
        Controls.Add(Guna2PictureBox2)
        Controls.Add(Guna2GradientPanel1)
        Controls.Add(txt_usuario)
        Controls.Add(txt_senha)
        Controls.Add(btn_entrar)
        Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Guna2Transition2.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Guna2GradientPanel1.ResumeLayout(False)
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btn_entrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents txt_usuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_senha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2Transition2 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button

End Class
