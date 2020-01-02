

--客户表
create table base_customer
(
	id uniqueidentifier primary key,
	no nvarchar(50) not null default(''),--客户编号
	jc_name nvarchar(200) not null default(''),--客户简称
	name nvarchar(200) not null default(''),--客户名称
	contacts nvarchar(100) not null default(''),--客户联系人
	contacts_phone nvarchar(100) not null default(''),--客户联系人电话
	email nvarchar(100),--邮箱
	grade uniqueidentifier,--客户等级
	address nvarchar(200) not null default(''),--客户地址
	isenable bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)


--供应商表
create table base_supplier
(
	id uniqueidentifier primary key,
	no nvarchar(50) not null default(''),--供应商编号
	jc_name nvarchar(200) not null default(''),--供应商简称
	name nvarchar(200) not null default(''),--供应商名称
	contacts nvarchar(100) not null default(''),--供应商联系人
	contacts_phone nvarchar(100) not null default(''),--供应商联系人电话
	email nvarchar(100),--邮箱
	grade uniqueidentifier,--供应商等级
	address nvarchar(200) not null default(''),--供应商地址
	isenable bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)


--基础数据表
create table base_data
(
	id uniqueidentifier primary key not null,--主键
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
	id uniqueidentifier primary key,
	no nvarchar(50) not null default(''),--产品编号
	name nvarchar(200) not null default(''),--产品名称
	type uniqueidentifier,--产品类型1 成品,2半成品
	unit uniqueidentifier not null,--单位
	price decimal(10,4) not null default(0),--商品单价
	isenable bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)


--部件信息表
create table base_parts
(
	id uniqueidentifier primary key not null,--id
	no nvarchar(50) not null default(''),--部件编号
	name varchar(50) not null default(''),--部件name
	type uniqueidentifier,--部件类型
	unit varchar(50) not null default(''),--单位
	isenable bit not null default(0),--是否禁用
	remark nvarchar(500),--备注
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)

--工序
create table base_process
(
	id uniqueidentifier primary key not null,--id
	no varchar(50) not null default(''),--工序编号
	name varchar(50) not null default(''),--工序名称
	type uniqueidentifier,--产品类型 1,主工序,2,辅助工序
	unit varchar(50) not null default(''),--单位
	isenable bit not null default(0),--是否禁用
	remark nvarchar(1000),--工艺要求
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)


--物料表
create table base_material
(
	id uniqueidentifier primary key,
	no nvarchar(50) not null default(''),--物料编号
	name nvarchar(50) not null default(''),--物料名称
	type uniqueidentifier not null,--物料分类
	price decimal(10,4) not null default(0),--采购单价
	isenable bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)

--仓库
create table base_warehouse
(
	id uniqueidentifier primary key not null,--主键
	no nvarchar(200) not null default(''),--条码号 前缀KQ
	name nvarchar(400) not null default(''),--库区名称
	warehouse_id uniqueidentifier not null,--所属仓库
	disabled bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)

--库区
create table base_area
(
	id uniqueidentifier primary key not null,--主键
	no nvarchar(200) not null default(''),--条码号 前缀KQ
	name nvarchar(400) not null default(''),--库区名称
	warehouse_id uniqueidentifier not null,--所属仓库
	disabled bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)

--货架
create table base_location
(
	id uniqueidentifier primary key not null,--主键
	no nvarchar(200) not null default(''),--
	name nvarchar(400) not null default(''),--货架名称
	warehouse_id uniqueidentifier not null,--所属仓库
	area_id uniqueidentifier not null,--所属库区
	disabled bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)