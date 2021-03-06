﻿namespace Nomina
{
    partial class FrmCrearCuentaContable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearCuentaContable));
            this.MiBarra = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAceptar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAuditoria = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ImagenesGrande = new System.Windows.Forms.ImageList(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cmbTipo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.txtCuenta = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.MiBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // MiBarra
            // 
            this.MiBarra.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.MiBarra.DockControls.Add(this.barDockControlTop);
            this.MiBarra.DockControls.Add(this.barDockControlBottom);
            this.MiBarra.DockControls.Add(this.barDockControlLeft);
            this.MiBarra.DockControls.Add(this.barDockControlRight);
            this.MiBarra.Form = this;
            this.MiBarra.Images = this.ImagenesGrande;
            this.MiBarra.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAceptar,
            this.btnCancelar,
            this.btnAuditoria});
            this.MiBarra.MaxItemId = 3;
            this.MiBarra.MdiMenuMergeStyle = DevExpress.XtraBars.BarMdiMenuMergeStyle.Always;
            // 
            // bar1
            // 
            this.bar1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.bar1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.bar1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.bar1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.bar1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.bar1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.bar1.BarName = "Tools";
            this.bar1.CanDockStyle = ((DevExpress.XtraBars.BarCanDockStyle)((((((DevExpress.XtraBars.BarCanDockStyle.Floating | DevExpress.XtraBars.BarCanDockStyle.Left) 
            | DevExpress.XtraBars.BarCanDockStyle.Top) 
            | DevExpress.XtraBars.BarCanDockStyle.Right) 
            | DevExpress.XtraBars.BarCanDockStyle.Bottom) 
            | DevExpress.XtraBars.BarCanDockStyle.Standalone)));
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAceptar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAuditoria, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.BarState = DevExpress.XtraBars.BarState.Expanded;
            this.bar1.Text = "Tools";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Default;
            this.btnAceptar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btnAceptar.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btnAceptar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Default;
            this.btnAceptar.Caption = "Aceptar";
            this.btnAceptar.Id = 0;
            this.btnAceptar.ImageIndex = 0;
            this.btnAceptar.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Default;
            this.btnAceptar.MergeType = DevExpress.XtraBars.BarMenuMerge.Add;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.btnAceptar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAceptar_ItemClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Default;
            this.btnCancelar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btnCancelar.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btnCancelar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Default;
            this.btnCancelar.Caption = "Cancelar";
            this.btnCancelar.Id = 1;
            this.btnCancelar.ImageIndex = 1;
            this.btnCancelar.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Default;
            this.btnCancelar.MergeType = DevExpress.XtraBars.BarMenuMerge.Add;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.btnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelar_ItemClick);
            // 
            // btnAuditoria
            // 
            this.btnAuditoria.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Default;
            this.btnAuditoria.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btnAuditoria.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btnAuditoria.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Default;
            this.btnAuditoria.Caption = "Auditoria";
            this.btnAuditoria.Id = 2;
            this.btnAuditoria.ImageIndex = 2;
            this.btnAuditoria.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Default;
            this.btnAuditoria.MergeType = DevExpress.XtraBars.BarMenuMerge.Add;
            this.btnAuditoria.Name = "btnAuditoria";
            this.btnAuditoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.btnAuditoria.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAuditoria_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.barDockControlTop.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.barDockControlTop.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.barDockControlTop.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.barDockControlTop.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.barDockControlTop.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(370, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.barDockControlBottom.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.barDockControlBottom.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.barDockControlBottom.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.barDockControlBottom.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.barDockControlBottom.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 137);
            this.barDockControlBottom.Size = new System.Drawing.Size(370, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.barDockControlLeft.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.barDockControlLeft.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.barDockControlLeft.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.barDockControlLeft.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.barDockControlLeft.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 95);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.barDockControlRight.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.barDockControlRight.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.barDockControlRight.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.barDockControlRight.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.barDockControlRight.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(370, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 95);
            // 
            // ImagenesGrande
            // 
            this.ImagenesGrande.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagenesGrande.ImageStream")));
            this.ImagenesGrande.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagenesGrande.Images.SetKeyName(0, "accept_48x48-32.gif");
            this.ImagenesGrande.Images.SetKeyName(1, "remove_48x48-32.gif");
            this.ImagenesGrande.Images.SetKeyName(2, "securitytransparente.png");
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControl1.Appearance.Control.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControl1.Appearance.Control.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControl1.Appearance.Control.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControl1.Appearance.Control.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControl1.Appearance.Control.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControl1.Appearance.ControlDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControl1.Appearance.ControlDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControl1.Appearance.ControlDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControl1.Appearance.ControlDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControl1.Appearance.ControlDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControl1.Appearance.ControlDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControl1.Appearance.ControlDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControl1.Appearance.ControlDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControl1.Appearance.ControlDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControl1.Appearance.ControlDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControl1.Appearance.ControlDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControl1.Appearance.ControlDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControl1.Appearance.ControlDropDownHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControl1.Appearance.ControlDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControl1.Appearance.ControlDropDownHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControl1.Appearance.ControlDropDownHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControl1.Appearance.ControlDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControl1.Appearance.ControlDropDownHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControl1.Appearance.ControlFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControl1.Appearance.ControlFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControl1.Appearance.ControlFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControl1.Appearance.ControlFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControl1.Appearance.ControlFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControl1.Appearance.ControlFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControl1.Appearance.ControlReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControl1.Appearance.ControlReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControl1.Appearance.ControlReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControl1.Appearance.ControlReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControl1.Appearance.ControlReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControl1.Appearance.ControlReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControl1.Controls.Add(this.cmbTipo);
            this.layoutControl1.Controls.Add(this.txtDescripcion);
            this.layoutControl1.Controls.Add(this.txtCuenta);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 42);
            this.layoutControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsFocus.MoveFocusDirection = DevExpress.XtraLayout.MoveFocusDirection.AcrossThenDown;
            this.layoutControl1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignMode.AlignInLayoutControl;
            this.layoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.Default;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(370, 95);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cmbTipo
            // 
            this.cmbTipo.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.cmbTipo.EnterMoveNextControl = true;
            this.cmbTipo.Location = new System.Drawing.Point(70, 60);
            this.cmbTipo.MenuManager = this.MiBarra;
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.cmbTipo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.cmbTipo.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.cmbTipo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.cmbTipo.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.cmbTipo.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.cmbTipo.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.cmbTipo.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.cmbTipo.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.cmbTipo.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.cmbTipo.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.cmbTipo.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.cmbTipo.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.cmbTipo.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.cmbTipo.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.cmbTipo.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.cmbTipo.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.cmbTipo.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.cmbTipo.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.cmbTipo.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.cmbTipo.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.cmbTipo.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.cmbTipo.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.cmbTipo.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.cmbTipo.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.cmbTipo.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.cmbTipo.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.cmbTipo.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.cmbTipo.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.cmbTipo.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.cmbTipo.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.cmbTipo.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.cmbTipo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            serializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            serializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            serializableAppearanceObject1.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            serializableAppearanceObject1.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            serializableAppearanceObject1.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            serializableAppearanceObject1.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.cmbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.cmbTipo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbTipo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.cmbTipo.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.cmbTipo.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Default;
            this.cmbTipo.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.Default;
            this.cmbTipo.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick;
            this.cmbTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbTipo.Size = new System.Drawing.Size(288, 20);
            this.cmbTipo.StyleController = this.layoutControl1;
            this.cmbTipo.TabIndex = 6;
            this.cmbTipo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.txtDescripcion.EnterMoveNextControl = true;
            this.txtDescripcion.Location = new System.Drawing.Point(70, 36);
            this.txtDescripcion.MenuManager = this.MiBarra;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.txtDescripcion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.txtDescripcion.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtDescripcion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtDescripcion.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtDescripcion.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtDescripcion.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtDescripcion.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtDescripcion.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtDescripcion.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtDescripcion.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtDescripcion.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtDescripcion.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtDescripcion.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtDescripcion.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtDescripcion.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtDescripcion.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtDescripcion.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtDescripcion.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtDescripcion.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtDescripcion.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtDescripcion.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtDescripcion.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtDescripcion.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtDescripcion.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtDescripcion.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtDescripcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescripcion.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtDescripcion.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.txtDescripcion.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.txtDescripcion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtDescripcion.Size = new System.Drawing.Size(288, 20);
            this.txtDescripcion.StyleController = this.layoutControl1;
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // txtCuenta
            // 
            this.txtCuenta.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.txtCuenta.EnterMoveNextControl = true;
            this.txtCuenta.Location = new System.Drawing.Point(70, 12);
            this.txtCuenta.MenuManager = this.MiBarra;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.txtCuenta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.txtCuenta.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtCuenta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtCuenta.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtCuenta.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtCuenta.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtCuenta.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtCuenta.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtCuenta.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtCuenta.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtCuenta.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtCuenta.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtCuenta.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtCuenta.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtCuenta.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtCuenta.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtCuenta.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtCuenta.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtCuenta.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtCuenta.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtCuenta.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtCuenta.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtCuenta.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtCuenta.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtCuenta.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtCuenta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txtCuenta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCuenta.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtCuenta.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.txtCuenta.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.txtCuenta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtCuenta.Size = new System.Drawing.Size(288, 20);
            this.txtCuenta.StyleController = this.layoutControl1;
            this.txtCuenta.TabIndex = 4;
            this.txtCuenta.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControlGroup1.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControlGroup1.AppearanceGroup.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControlGroup1.AppearanceGroup.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControlGroup1.AppearanceGroup.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControlGroup1.AppearanceGroup.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControlGroup1.AppearanceItemCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControlGroup1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControlGroup1.AppearanceItemCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControlGroup1.AppearanceItemCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControlGroup1.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControlGroup1.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControlGroup1.AppearanceTabPage.Header.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControlGroup1.AppearanceTabPage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControlGroup1.AppearanceTabPage.Header.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControlGroup1.AppearanceTabPage.Header.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControlGroup1.AppearanceTabPage.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControlGroup1.AppearanceTabPage.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControlGroup1.AppearanceTabPage.HeaderActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControlGroup1.AppearanceTabPage.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControlGroup1.AppearanceTabPage.HeaderActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControlGroup1.AppearanceTabPage.HeaderActive.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControlGroup1.AppearanceTabPage.HeaderActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControlGroup1.AppearanceTabPage.HeaderActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControlGroup1.AppearanceTabPage.HeaderDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControlGroup1.AppearanceTabPage.HeaderDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControlGroup1.AppearanceTabPage.HeaderDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControlGroup1.AppearanceTabPage.HeaderDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControlGroup1.AppearanceTabPage.HeaderDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControlGroup1.AppearanceTabPage.HeaderDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControlGroup1.AppearanceTabPage.HeaderHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControlGroup1.AppearanceTabPage.HeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControlGroup1.AppearanceTabPage.HeaderHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControlGroup1.AppearanceTabPage.HeaderHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControlGroup1.AppearanceTabPage.HeaderHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControlGroup1.AppearanceTabPage.HeaderHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControlGroup1.AppearanceTabPage.PageClient.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControlGroup1.AppearanceTabPage.PageClient.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControlGroup1.AppearanceTabPage.PageClient.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControlGroup1.AppearanceTabPage.PageClient.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControlGroup1.AppearanceTabPage.PageClient.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControlGroup1.AppearanceTabPage.PageClient.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControlGroup1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.layoutControlGroup1.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.Default;
            this.layoutControlGroup1.ContentImageAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.DefaultLayoutType = DevExpress.XtraLayout.Utils.LayoutType.Vertical;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.Default;
            this.layoutControlGroup1.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Normal;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsCustomization.AllowDrag = DevExpress.XtraLayout.ItemDragDropMode.Default;
            this.layoutControlGroup1.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.Default;
            this.layoutControlGroup1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.UseParentOptions;
            this.layoutControlGroup1.OptionsToolTip.IconToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.layoutControlGroup1.OptionsToolTip.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.layoutControlGroup1.Size = new System.Drawing.Size(370, 95);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlGroup1.TextVisible = false;
            this.layoutControlGroup1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControlItem1.Control = this.txtCuenta;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsCustomization.AllowDrag = DevExpress.XtraLayout.ItemDragDropMode.Default;
            this.layoutControlItem1.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.Default;
            this.layoutControlItem1.OptionsToolTip.IconToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.layoutControlItem1.OptionsToolTip.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.layoutControlItem1.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Default;
            this.layoutControlItem1.Text = "Cuenta";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.UseParentOptions;
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(54, 13);
            this.layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControlItem2.Control = this.txtDescripcion;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsCustomization.AllowDrag = DevExpress.XtraLayout.ItemDragDropMode.Default;
            this.layoutControlItem2.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.Default;
            this.layoutControlItem2.OptionsToolTip.IconToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.layoutControlItem2.OptionsToolTip.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.layoutControlItem2.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Default;
            this.layoutControlItem2.Text = "Descripcion";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.UseParentOptions;
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(54, 13);
            this.layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.layoutControlItem3.Control = this.cmbTipo;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsCustomization.AllowDrag = DevExpress.XtraLayout.ItemDragDropMode.Default;
            this.layoutControlItem3.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.Default;
            this.layoutControlItem3.OptionsToolTip.IconToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.layoutControlItem3.OptionsToolTip.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.layoutControlItem3.Size = new System.Drawing.Size(350, 27);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Default;
            this.layoutControlItem3.Text = "Tipo";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.UseParentOptions;
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(54, 13);
            this.layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            // 
            // FrmCrearCuentaContable
            // 
            this.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 137);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.Name = "FrmCrearCuentaContable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cuenta Contable";
            ((System.ComponentModel.ISupportInitialize)(this.MiBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager MiBarra;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAceptar;
        private DevExpress.XtraBars.BarButtonItem btnCancelar;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.ImageList ImagenesGrande;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTipo;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.TextEdit txtCuenta;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        CuentaContable cuentacontable;
        private DevExpress.XtraBars.BarButtonItem btnAuditoria;
    }
}