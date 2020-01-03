

--客户表
create table base_customer
(
	id int identity(1,1) primary key,
	no nvarchar(50) not null default(''),--客户编号
	jc_name nvarchar(200) not null default(''),--客户简称
	name nvarchar(200) not null default(''),--客户名称
	contacts nvarchar(100) not null default(''),--客户联系人
	contacts_phone nvarchar(100) not null default(''),--客户联系人电话
	email nvarchar(100),--邮箱
	grade int,--客户等级
	address nvarchar(200) not null default(''),--客户地址
	isenable bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)


--供应商表
create table base_supplier
(
	id int identity(1,1) primary key,
	no nvarchar(50) not null default(''),--供应商编号
	jc_name nvarchar(200) not null default(''),--供应商简称
	name nvarchar(200) not null default(''),--供应商名称
	contacts nvarchar(100) not null default(''),--供应商联系人
	contacts_phone nvarchar(100) not null default(''),--供应商联系人电话
	email nvarchar(100),--邮箱
	grade int,--供应商等级
	address nvarchar(200) not null default(''),--供应商地址
	isenable bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)


--基础数据表
create table base_data
(
	id int identity(1,1) primary key not null,--主键
	name nvarchar(100) not null default(''),---名称
	type int not null default(0),--类型
	remark nvarchar(300),--备注说明
	isenable bit not null default(0),--是否禁用
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)

--产品表
create table base_product
(
	id int identity(1,1) primary key,
	no nvarchar(50) not null default(''),--产品编号
	name nvarchar(200) not null default(''),--产品名称
	type int,--产品类型1 成品,2半成品
	guige nvarchar(200),--规格
	unit int not null,--单位
	price decimal(10,4) not null default(0),--商品单价
	isenable bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)


--部件信息表
create table base_parts
(
	id int identity(1,1) primary key not null,--id
	no nvarchar(50) not null default(''),--部件编号
	name varchar(50) not null default(''),--部件name
	type int,--部件类型
	unit varchar(50) not null default(''),--单位
	guige nvarchar(200),--规格
	isenable bit not null default(0),--是否禁用
	remark nvarchar(500),--备注
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)

--部件工艺表
create table base_technology
(
	id int identity(1,1) primary key not null,--id
	parts_id int not null,--部件id
	name varchar(50) not null default(''),--工艺名称
	orderby int not null,
	remark nvarchar(max),--工艺要求
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)


--工序
create table base_process
(
	id int identity(1,1) primary key not null,--id
	no varchar(50) not null default(''),--工序编号
	name varchar(50) not null default(''),--工序名称
	type int,--产品类型 1,主工序,2,辅助工序
	guige nvarchar(200),--规格
	unit varchar(50) not null default(''),--单位
	isenable bit not null default(0),--是否禁用
	remark nvarchar(1000),--工艺要求
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)


--物料表
create table base_material
(
	id int identity(1,1) primary key,
	no nvarchar(50) not null default(''),--物料编号
	name nvarchar(50) not null default(''),--物料名称
	type int not null,--物料分类
	price decimal(10,4) not null default(0),--采购单价
	guige nvarchar(200),--规格
	isenable bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)

--仓库
create table base_warehouse
(
	id int identity(1,1) primary key not null,--主键
	no nvarchar(200) not null default(''),--条码号 前缀KQ
	name nvarchar(400) not null default(''),--库区名称
	warehouse_id int not null,--所属仓库
	disabled bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)

--库区
create table base_area
(
	id int identity(1,1) primary key not null,--主键
	no nvarchar(200) not null default(''),--条码号 前缀KQ
	name nvarchar(400) not null default(''),--库区名称
	warehouse_id int not null,--所属仓库
	disabled bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)

--货架
create table base_location
(
	id int identity(1,1) primary key not null,--主键
	no nvarchar(200) not null default(''),--
	name nvarchar(400) not null default(''),--货架名称
	warehouse_id int not null,--所属仓库
	area_id int not null,--所属库区
	disabled bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)


--施工单表
create table erp_construction
(
	id int identity(1,1) not null,--主键
	no nvarchar(100) not null default('') primary key,--TO00001
	product_no nvarchar(100) not null,--产品编号
	product_name nvarchar(100) not null,--产品名称
	customer_no nvarchar(100) not null,--客户编号
	customer_name nvarchar(100) not null,--客户名称
	--type int not null,--施工单类型1,自产,2外发
	number int not null,--数量
	practical_number int,--实际生产数量
	loss_number int,--损耗数量
	guige nvarchar(100) not null,--规格
	zhuangdinfa nvarchar(100) not null,--装订法
	baozhuangfa nvarchar(100) not null,--包装法
	address nvarchar(200) not null,--收货地址
	delivery_date date not null,--交货日期
	source_no nvarchar(100),--源数据编号
	state int not null,--状态 0待确认 --1计划中,2生产中,3已完成
	affirm_time datetime,--确认时间
	affirm_username nvarchar(40),--确认用户
	finish_time datetime,--完成时间
	finish_username nvarchar(40),--完成用户
	create_time datetime not null default(getdate()),--开单时间
	create_username nvarchar(40) not null,--开单用户
)

--施工单部件表
create table erp_parts
(
	id int identity(1,1) not null,--主键
	con_no nvarchar(200) not null,--施工单ID
	parts_no nvarchar(50) not null,--部件编号
	parts_name nvarchar(200) not null,--部件名称
	number int not null,--生产数量
	state int not null,--状态 0待确认 --1待生产,2生产中,3已完成
	remarrk nvarchar(max),--备注
	create_time datetime not null default(getdate()),--开单时间
	create_username nvarchar(40) not null,--开单用户
)

--部件生产工序表
create table erp_process
(
	id int identity(1,1) not null,--主键
	con_no nvarchar(200) not null,--施工单编号
	erp_parts_id int not null,--所属部件
	process_no nvarchar(50) not null,--工序编号
	process_name nvarchar(100) not null,--工序名称 
	sort int not null,--排序号
	number int not null,--计划生产数量
	practical_number int,--已生产数量
	loss_number int,--损耗数量
	is_waifa bit not null default(0),--是否外发
	unit nvarchar(20) not null,--单位
	knife_no nvarchar(100) not null,--刀版
	remarrk nvarchar(max),--工序要求
	state int not null,--状态 0待确认 --1待生产,2生产中,3已完成
	create_time datetime not null default(getdate()),--开单时间
	create_username nvarchar(40) not null,--开单用户
)

--部件材料表
create table erp_material
(
	id int identity(1,1) not null,--主键
	con_no nvarchar(200) not null,--施工单编号
	erp_parts_id int not null,--所属部件
	material_no nvarchar(50) not null,--物料编号
	material_name nvarchar(100) not null,--编号名称
	is_waifadailiao bit not null default(0),--是否是外发带料
	number int,--需求数量
	unit nvarchar(20) not null,--单位
	remarrk nvarchar(max),--备注
	create_time datetime not null default(getdate()),--开单时间
	create_username nvarchar(40) not null,--开单用户
)


--外发单