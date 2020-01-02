
--产品表
create table base_product
(
	id uniqueidentifier primary key,
	no nvarchar(50) not null default(''),--产品编号
	name nvarchar(200) not null default(''),--产品名称
	type int,--产品类型1 成品,2半成品
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
	type varchar(30) not null default(''),--不见 
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
	type int,--产品类型 1,主工序,2,辅助工序
	unit varchar(50) not null default(''),--单位
	isenable bit not null default(0),--是否禁用
	remark nvarchar(1000),--工艺要求
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)


--物料表
create table BaseMaterial
(
	id uniqueidentifier primary key,
	no nvarchar(50) not null default(''),--物料编号
	name nvarchar(50) not null default(''),--物料名称
	type uniqueidentifier not null,--物料分类
	warehouse_id uniqueidentifier not null,--仓库
	purchase_price decimal(10,4) not null default(0),--采购单价
	disabled bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)