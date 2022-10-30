﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiCuaHangDienThoai
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLiCuaHangDienThoai")]
	public partial class QLDTDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDANHMUC(DANHMUC instance);
    partial void UpdateDANHMUC(DANHMUC instance);
    partial void DeleteDANHMUC(DANHMUC instance);
    partial void InsertTAIKHOAN(TAIKHOAN instance);
    partial void UpdateTAIKHOAN(TAIKHOAN instance);
    partial void DeleteTAIKHOAN(TAIKHOAN instance);
    partial void InsertHOADON(HOADON instance);
    partial void UpdateHOADON(HOADON instance);
    partial void DeleteHOADON(HOADON instance);
    partial void InsertHOADONCHITIET(HOADONCHITIET instance);
    partial void UpdateHOADONCHITIET(HOADONCHITIET instance);
    partial void DeleteHOADONCHITIET(HOADONCHITIET instance);
    partial void InsertNHACUNGCAP(NHACUNGCAP instance);
    partial void UpdateNHACUNGCAP(NHACUNGCAP instance);
    partial void DeleteNHACUNGCAP(NHACUNGCAP instance);
    partial void InsertSANPHAM(SANPHAM instance);
    partial void UpdateSANPHAM(SANPHAM instance);
    partial void DeleteSANPHAM(SANPHAM instance);
    #endregion
		
		public QLDTDataContext() : 
				base(global::QuanLiCuaHangDienThoai.Properties.Settings.Default.QuanLiCuaHangDienThoaiConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLDTDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLDTDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLDTDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLDTDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DANHMUC> DANHMUCs
		{
			get
			{
				return this.GetTable<DANHMUC>();
			}
		}
		
		public System.Data.Linq.Table<TAIKHOAN> TAIKHOANs
		{
			get
			{
				return this.GetTable<TAIKHOAN>();
			}
		}
		
		public System.Data.Linq.Table<HOADON> HOADONs
		{
			get
			{
				return this.GetTable<HOADON>();
			}
		}
		
		public System.Data.Linq.Table<HOADONCHITIET> HOADONCHITIETs
		{
			get
			{
				return this.GetTable<HOADONCHITIET>();
			}
		}
		
		public System.Data.Linq.Table<NHACUNGCAP> NHACUNGCAPs
		{
			get
			{
				return this.GetTable<NHACUNGCAP>();
			}
		}
		
		public System.Data.Linq.Table<SANPHAM> SANPHAMs
		{
			get
			{
				return this.GetTable<SANPHAM>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DANHMUC")]
	public partial class DANHMUC : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maDM;
		
		private string _tenDM;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaDMChanging(string value);
    partial void OnmaDMChanged();
    partial void OntenDMChanging(string value);
    partial void OntenDMChanged();
    #endregion
		
		public DANHMUC()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maDM", DbType="NVarChar(39) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maDM
		{
			get
			{
				return this._maDM;
			}
			set
			{
				if ((this._maDM != value))
				{
					this.OnmaDMChanging(value);
					this.SendPropertyChanging();
					this._maDM = value;
					this.SendPropertyChanged("maDM");
					this.OnmaDMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenDM", DbType="NVarChar(39) NOT NULL", CanBeNull=false)]
		public string tenDM
		{
			get
			{
				return this._tenDM;
			}
			set
			{
				if ((this._tenDM != value))
				{
					this.OntenDMChanging(value);
					this.SendPropertyChanging();
					this._tenDM = value;
					this.SendPropertyChanged("tenDM");
					this.OntenDMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DANHMUC_SANPHAM", Storage="_SANPHAMs", ThisKey="maDM", OtherKey="maDM")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.DANHMUC = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.DANHMUC = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TAIKHOAN")]
	public partial class TAIKHOAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _username;
		
		private string _mk;
		
		private string _email;
		
		private string _ten;
		
		private System.DateTime _ngaySinh;
		
		private string _hinhAnh;
		
		private string _sdt;
		
		private string _loai;
		
		private System.DateTime _ngayTao;
		
		private EntitySet<HOADON> _HOADONs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnmkChanging(string value);
    partial void OnmkChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OntenChanging(string value);
    partial void OntenChanged();
    partial void OnngaySinhChanging(System.DateTime value);
    partial void OnngaySinhChanged();
    partial void OnhinhAnhChanging(string value);
    partial void OnhinhAnhChanged();
    partial void OnsdtChanging(string value);
    partial void OnsdtChanged();
    partial void OnloaiChanging(string value);
    partial void OnloaiChanged();
    partial void OnngayTaoChanging(System.DateTime value);
    partial void OnngayTaoChanged();
    #endregion
		
		public TAIKHOAN()
		{
			this._HOADONs = new EntitySet<HOADON>(new Action<HOADON>(this.attach_HOADONs), new Action<HOADON>(this.detach_HOADONs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(39) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mk", DbType="NVarChar(39) NOT NULL", CanBeNull=false)]
		public string mk
		{
			get
			{
				return this._mk;
			}
			set
			{
				if ((this._mk != value))
				{
					this.OnmkChanging(value);
					this.SendPropertyChanging();
					this._mk = value;
					this.SendPropertyChanged("mk");
					this.OnmkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(39) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ten", DbType="NVarChar(39) NOT NULL", CanBeNull=false)]
		public string ten
		{
			get
			{
				return this._ten;
			}
			set
			{
				if ((this._ten != value))
				{
					this.OntenChanging(value);
					this.SendPropertyChanging();
					this._ten = value;
					this.SendPropertyChanged("ten");
					this.OntenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaySinh", DbType="Date NOT NULL")]
		public System.DateTime ngaySinh
		{
			get
			{
				return this._ngaySinh;
			}
			set
			{
				if ((this._ngaySinh != value))
				{
					this.OnngaySinhChanging(value);
					this.SendPropertyChanging();
					this._ngaySinh = value;
					this.SendPropertyChanged("ngaySinh");
					this.OnngaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinhAnh", DbType="NVarChar(MAX)")]
		public string hinhAnh
		{
			get
			{
				return this._hinhAnh;
			}
			set
			{
				if ((this._hinhAnh != value))
				{
					this.OnhinhAnhChanging(value);
					this.SendPropertyChanging();
					this._hinhAnh = value;
					this.SendPropertyChanged("hinhAnh");
					this.OnhinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdt", DbType="VarChar(39) NOT NULL", CanBeNull=false)]
		public string sdt
		{
			get
			{
				return this._sdt;
			}
			set
			{
				if ((this._sdt != value))
				{
					this.OnsdtChanging(value);
					this.SendPropertyChanging();
					this._sdt = value;
					this.SendPropertyChanged("sdt");
					this.OnsdtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_loai", DbType="VarChar(39) NOT NULL", CanBeNull=false)]
		public string loai
		{
			get
			{
				return this._loai;
			}
			set
			{
				if ((this._loai != value))
				{
					this.OnloaiChanging(value);
					this.SendPropertyChanging();
					this._loai = value;
					this.SendPropertyChanged("loai");
					this.OnloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayTao", DbType="Date NOT NULL")]
		public System.DateTime ngayTao
		{
			get
			{
				return this._ngayTao;
			}
			set
			{
				if ((this._ngayTao != value))
				{
					this.OnngayTaoChanging(value);
					this.SendPropertyChanging();
					this._ngayTao = value;
					this.SendPropertyChanged("ngayTao");
					this.OnngayTaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TAIKHOAN_HOADON", Storage="_HOADONs", ThisKey="username", OtherKey="username")]
		public EntitySet<HOADON> HOADONs
		{
			get
			{
				return this._HOADONs;
			}
			set
			{
				this._HOADONs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.TAIKHOAN = this;
		}
		
		private void detach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.TAIKHOAN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOADON")]
	public partial class HOADON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maHD;
		
		private string _username;
		
		private string _tenKH;
		
		private string _sdt;
		
		private System.DateTime _ngayTao;
		
		private EntityRef<HOADONCHITIET> _HOADONCHITIET;
		
		private EntityRef<TAIKHOAN> _TAIKHOAN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaHDChanging(string value);
    partial void OnmaHDChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OntenKHChanging(string value);
    partial void OntenKHChanged();
    partial void OnsdtChanging(string value);
    partial void OnsdtChanged();
    partial void OnngayTaoChanging(System.DateTime value);
    partial void OnngayTaoChanged();
    #endregion
		
		public HOADON()
		{
			this._HOADONCHITIET = default(EntityRef<HOADONCHITIET>);
			this._TAIKHOAN = default(EntityRef<TAIKHOAN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maHD", DbType="NVarChar(39) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maHD
		{
			get
			{
				return this._maHD;
			}
			set
			{
				if ((this._maHD != value))
				{
					this.OnmaHDChanging(value);
					this.SendPropertyChanging();
					this._maHD = value;
					this.SendPropertyChanged("maHD");
					this.OnmaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(39) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					if (this._TAIKHOAN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenKH", DbType="NVarChar(39) NOT NULL", CanBeNull=false)]
		public string tenKH
		{
			get
			{
				return this._tenKH;
			}
			set
			{
				if ((this._tenKH != value))
				{
					this.OntenKHChanging(value);
					this.SendPropertyChanging();
					this._tenKH = value;
					this.SendPropertyChanged("tenKH");
					this.OntenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdt", DbType="NVarChar(39) NOT NULL", CanBeNull=false)]
		public string sdt
		{
			get
			{
				return this._sdt;
			}
			set
			{
				if ((this._sdt != value))
				{
					this.OnsdtChanging(value);
					this.SendPropertyChanging();
					this._sdt = value;
					this.SendPropertyChanged("sdt");
					this.OnsdtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayTao", DbType="Date NOT NULL")]
		public System.DateTime ngayTao
		{
			get
			{
				return this._ngayTao;
			}
			set
			{
				if ((this._ngayTao != value))
				{
					this.OnngayTaoChanging(value);
					this.SendPropertyChanging();
					this._ngayTao = value;
					this.SendPropertyChanged("ngayTao");
					this.OnngayTaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HOADON_HOADONCHITIET", Storage="_HOADONCHITIET", ThisKey="maHD", OtherKey="maHD", IsUnique=true, IsForeignKey=false)]
		public HOADONCHITIET HOADONCHITIET
		{
			get
			{
				return this._HOADONCHITIET.Entity;
			}
			set
			{
				HOADONCHITIET previousValue = this._HOADONCHITIET.Entity;
				if (((previousValue != value) 
							|| (this._HOADONCHITIET.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HOADONCHITIET.Entity = null;
						previousValue.HOADON = null;
					}
					this._HOADONCHITIET.Entity = value;
					if ((value != null))
					{
						value.HOADON = this;
					}
					this.SendPropertyChanged("HOADONCHITIET");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TAIKHOAN_HOADON", Storage="_TAIKHOAN", ThisKey="username", OtherKey="username", IsForeignKey=true)]
		public TAIKHOAN TAIKHOAN
		{
			get
			{
				return this._TAIKHOAN.Entity;
			}
			set
			{
				TAIKHOAN previousValue = this._TAIKHOAN.Entity;
				if (((previousValue != value) 
							|| (this._TAIKHOAN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TAIKHOAN.Entity = null;
						previousValue.HOADONs.Remove(this);
					}
					this._TAIKHOAN.Entity = value;
					if ((value != null))
					{
						value.HOADONs.Add(this);
						this._username = value.username;
					}
					else
					{
						this._username = default(string);
					}
					this.SendPropertyChanged("TAIKHOAN");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOADONCHITIET")]
	public partial class HOADONCHITIET : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maHD;
		
		private string _maSP;
		
		private int _gia;
		
		private int _soLuong;
		
		private int _thanhTien;
		
		private EntityRef<HOADON> _HOADON;
		
		private EntityRef<SANPHAM> _SANPHAM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaHDChanging(string value);
    partial void OnmaHDChanged();
    partial void OnmaSPChanging(string value);
    partial void OnmaSPChanged();
    partial void OngiaChanging(int value);
    partial void OngiaChanged();
    partial void OnsoLuongChanging(int value);
    partial void OnsoLuongChanged();
    partial void OnthanhTienChanging(int value);
    partial void OnthanhTienChanged();
    #endregion
		
		public HOADONCHITIET()
		{
			this._HOADON = default(EntityRef<HOADON>);
			this._SANPHAM = default(EntityRef<SANPHAM>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maHD", DbType="NVarChar(39) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maHD
		{
			get
			{
				return this._maHD;
			}
			set
			{
				if ((this._maHD != value))
				{
					if (this._HOADON.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaHDChanging(value);
					this.SendPropertyChanging();
					this._maHD = value;
					this.SendPropertyChanged("maHD");
					this.OnmaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maSP", DbType="NVarChar(39) NOT NULL", CanBeNull=false)]
		public string maSP
		{
			get
			{
				return this._maSP;
			}
			set
			{
				if ((this._maSP != value))
				{
					if (this._SANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaSPChanging(value);
					this.SendPropertyChanging();
					this._maSP = value;
					this.SendPropertyChanged("maSP");
					this.OnmaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gia", DbType="Int NOT NULL")]
		public int gia
		{
			get
			{
				return this._gia;
			}
			set
			{
				if ((this._gia != value))
				{
					this.OngiaChanging(value);
					this.SendPropertyChanging();
					this._gia = value;
					this.SendPropertyChanged("gia");
					this.OngiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soLuong", DbType="Int NOT NULL")]
		public int soLuong
		{
			get
			{
				return this._soLuong;
			}
			set
			{
				if ((this._soLuong != value))
				{
					this.OnsoLuongChanging(value);
					this.SendPropertyChanging();
					this._soLuong = value;
					this.SendPropertyChanged("soLuong");
					this.OnsoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_thanhTien", DbType="Int NOT NULL")]
		public int thanhTien
		{
			get
			{
				return this._thanhTien;
			}
			set
			{
				if ((this._thanhTien != value))
				{
					this.OnthanhTienChanging(value);
					this.SendPropertyChanging();
					this._thanhTien = value;
					this.SendPropertyChanged("thanhTien");
					this.OnthanhTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HOADON_HOADONCHITIET", Storage="_HOADON", ThisKey="maHD", OtherKey="maHD", IsForeignKey=true)]
		public HOADON HOADON
		{
			get
			{
				return this._HOADON.Entity;
			}
			set
			{
				HOADON previousValue = this._HOADON.Entity;
				if (((previousValue != value) 
							|| (this._HOADON.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HOADON.Entity = null;
						previousValue.HOADONCHITIET = null;
					}
					this._HOADON.Entity = value;
					if ((value != null))
					{
						value.HOADONCHITIET = this;
						this._maHD = value.maHD;
					}
					else
					{
						this._maHD = default(string);
					}
					this.SendPropertyChanged("HOADON");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_HOADONCHITIET", Storage="_SANPHAM", ThisKey="maSP", OtherKey="maSP", IsForeignKey=true)]
		public SANPHAM SANPHAM
		{
			get
			{
				return this._SANPHAM.Entity;
			}
			set
			{
				SANPHAM previousValue = this._SANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._SANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SANPHAM.Entity = null;
						previousValue.HOADONCHITIETs.Remove(this);
					}
					this._SANPHAM.Entity = value;
					if ((value != null))
					{
						value.HOADONCHITIETs.Add(this);
						this._maSP = value.maSP;
					}
					else
					{
						this._maSP = default(string);
					}
					this.SendPropertyChanged("SANPHAM");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHACUNGCAP")]
	public partial class NHACUNGCAP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maNCC;
		
		private string _tenNCC;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaNCCChanging(string value);
    partial void OnmaNCCChanged();
    partial void OntenNCCChanging(string value);
    partial void OntenNCCChanged();
    #endregion
		
		public NHACUNGCAP()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maNCC", DbType="NVarChar(39) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maNCC
		{
			get
			{
				return this._maNCC;
			}
			set
			{
				if ((this._maNCC != value))
				{
					this.OnmaNCCChanging(value);
					this.SendPropertyChanging();
					this._maNCC = value;
					this.SendPropertyChanged("maNCC");
					this.OnmaNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenNCC", DbType="NVarChar(39) NOT NULL", CanBeNull=false)]
		public string tenNCC
		{
			get
			{
				return this._tenNCC;
			}
			set
			{
				if ((this._tenNCC != value))
				{
					this.OntenNCCChanging(value);
					this.SendPropertyChanging();
					this._tenNCC = value;
					this.SendPropertyChanged("tenNCC");
					this.OntenNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHACUNGCAP_SANPHAM", Storage="_SANPHAMs", ThisKey="maNCC", OtherKey="maNCC")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.NHACUNGCAP = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.NHACUNGCAP = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SANPHAM")]
	public partial class SANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maSP;
		
		private string _tenSP;
		
		private int _gia;
		
		private string _hinhAnh;
		
		private string _soLuong;
		
		private string _maDM;
		
		private string _maNCC;
		
		private EntitySet<HOADONCHITIET> _HOADONCHITIETs;
		
		private EntityRef<DANHMUC> _DANHMUC;
		
		private EntityRef<NHACUNGCAP> _NHACUNGCAP;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaSPChanging(string value);
    partial void OnmaSPChanged();
    partial void OntenSPChanging(string value);
    partial void OntenSPChanged();
    partial void OngiaChanging(int value);
    partial void OngiaChanged();
    partial void OnhinhAnhChanging(string value);
    partial void OnhinhAnhChanged();
    partial void OnsoLuongChanging(string value);
    partial void OnsoLuongChanged();
    partial void OnmaDMChanging(string value);
    partial void OnmaDMChanged();
    partial void OnmaNCCChanging(string value);
    partial void OnmaNCCChanged();
    #endregion
		
		public SANPHAM()
		{
			this._HOADONCHITIETs = new EntitySet<HOADONCHITIET>(new Action<HOADONCHITIET>(this.attach_HOADONCHITIETs), new Action<HOADONCHITIET>(this.detach_HOADONCHITIETs));
			this._DANHMUC = default(EntityRef<DANHMUC>);
			this._NHACUNGCAP = default(EntityRef<NHACUNGCAP>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maSP", DbType="NVarChar(39) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maSP
		{
			get
			{
				return this._maSP;
			}
			set
			{
				if ((this._maSP != value))
				{
					this.OnmaSPChanging(value);
					this.SendPropertyChanging();
					this._maSP = value;
					this.SendPropertyChanged("maSP");
					this.OnmaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenSP", DbType="NVarChar(39) NOT NULL", CanBeNull=false)]
		public string tenSP
		{
			get
			{
				return this._tenSP;
			}
			set
			{
				if ((this._tenSP != value))
				{
					this.OntenSPChanging(value);
					this.SendPropertyChanging();
					this._tenSP = value;
					this.SendPropertyChanged("tenSP");
					this.OntenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gia", DbType="Int NOT NULL")]
		public int gia
		{
			get
			{
				return this._gia;
			}
			set
			{
				if ((this._gia != value))
				{
					this.OngiaChanging(value);
					this.SendPropertyChanging();
					this._gia = value;
					this.SendPropertyChanged("gia");
					this.OngiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinhAnh", DbType="NVarChar(MAX)")]
		public string hinhAnh
		{
			get
			{
				return this._hinhAnh;
			}
			set
			{
				if ((this._hinhAnh != value))
				{
					this.OnhinhAnhChanging(value);
					this.SendPropertyChanging();
					this._hinhAnh = value;
					this.SendPropertyChanged("hinhAnh");
					this.OnhinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soLuong", DbType="NVarChar(39) NOT NULL", CanBeNull=false)]
		public string soLuong
		{
			get
			{
				return this._soLuong;
			}
			set
			{
				if ((this._soLuong != value))
				{
					this.OnsoLuongChanging(value);
					this.SendPropertyChanging();
					this._soLuong = value;
					this.SendPropertyChanged("soLuong");
					this.OnsoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maDM", DbType="NVarChar(39) NOT NULL", CanBeNull=false)]
		public string maDM
		{
			get
			{
				return this._maDM;
			}
			set
			{
				if ((this._maDM != value))
				{
					if (this._DANHMUC.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaDMChanging(value);
					this.SendPropertyChanging();
					this._maDM = value;
					this.SendPropertyChanged("maDM");
					this.OnmaDMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maNCC", DbType="NVarChar(39) NOT NULL", CanBeNull=false)]
		public string maNCC
		{
			get
			{
				return this._maNCC;
			}
			set
			{
				if ((this._maNCC != value))
				{
					if (this._NHACUNGCAP.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaNCCChanging(value);
					this.SendPropertyChanging();
					this._maNCC = value;
					this.SendPropertyChanged("maNCC");
					this.OnmaNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_HOADONCHITIET", Storage="_HOADONCHITIETs", ThisKey="maSP", OtherKey="maSP")]
		public EntitySet<HOADONCHITIET> HOADONCHITIETs
		{
			get
			{
				return this._HOADONCHITIETs;
			}
			set
			{
				this._HOADONCHITIETs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DANHMUC_SANPHAM", Storage="_DANHMUC", ThisKey="maDM", OtherKey="maDM", IsForeignKey=true)]
		public DANHMUC DANHMUC
		{
			get
			{
				return this._DANHMUC.Entity;
			}
			set
			{
				DANHMUC previousValue = this._DANHMUC.Entity;
				if (((previousValue != value) 
							|| (this._DANHMUC.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DANHMUC.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._DANHMUC.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._maDM = value.maDM;
					}
					else
					{
						this._maDM = default(string);
					}
					this.SendPropertyChanged("DANHMUC");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHACUNGCAP_SANPHAM", Storage="_NHACUNGCAP", ThisKey="maNCC", OtherKey="maNCC", IsForeignKey=true)]
		public NHACUNGCAP NHACUNGCAP
		{
			get
			{
				return this._NHACUNGCAP.Entity;
			}
			set
			{
				NHACUNGCAP previousValue = this._NHACUNGCAP.Entity;
				if (((previousValue != value) 
							|| (this._NHACUNGCAP.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NHACUNGCAP.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._NHACUNGCAP.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._maNCC = value.maNCC;
					}
					else
					{
						this._maNCC = default(string);
					}
					this.SendPropertyChanged("NHACUNGCAP");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_HOADONCHITIETs(HOADONCHITIET entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = this;
		}
		
		private void detach_HOADONCHITIETs(HOADONCHITIET entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = null;
		}
	}
}
#pragma warning restore 1591
