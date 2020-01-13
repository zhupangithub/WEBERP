

--客户表
create table base_customer
(
	id int identity(1,1) primary key,
	jc_name nvarchar(200) not null default(''),--客户简称
	name nvarchar(200) not null default(''),--客户名称
	contacts nvarchar(100) not null default(''),--客户联系人
	contacts_phone nvarchar(100) not null default(''),--客户联系人电话
	email nvarchar(100),--邮箱
	grade nvarchar(20),--客户等级
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
	jc_name nvarchar(200) not null default(''),--供应商简称
	name nvarchar(200) not null default(''),--供应商名称
	contacts nvarchar(100) not null default(''),--供应商联系人
	contacts_phone nvarchar(100) not null default(''),--供应商联系人电话
	email nvarchar(100),--邮箱
	grade nvarchar(20),--供应商等级
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
	type nvarchar(20) not null default(0),--类型
	remark nvarchar(300),--备注说明
	isenable bit not null default(0),--是否禁用
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)

--产品表
create table base_product
(
	id int identity(1,1) primary key,
	name nvarchar(200) not null default(''),--产品名称
	type nvarchar(20),--产品类型1 成品,2半成品
	guige nvarchar(200),--规格
	unit nvarchar(20) not null,--单位
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
	name varchar(50) not null default(''),--部件name
	type nvarchar(20),--部件类型
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
	name varchar(50) not null default(''),--工序名称
	type nvarchar(20),--工序类型 1,主工序,2,辅助工序
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
	name nvarchar(50) not null default(''),--物料名称
	type nvarchar(20) not null,--物料分类
	unit varchar(10) not null default(''),--单位
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
	name nvarchar(100) not null default(''),--库区名称
	isenable bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)


--库区
create table base_area
(
	id int identity(1,1) primary key not null,--主键
	name nvarchar(100) not null default(''),--库区名称
	warehouse_id int not null,--所属仓库
	isenable bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)


--货架
create table base_location
(
	id int identity(1,1) primary key not null,--主键
	name nvarchar(100) not null default(''),--货架名称
	warehouse_id int not null,--所属仓库
	wname nvarchar(50),
	area_id int not null,--所属库区
	aname nvarchar(50),
	isenable bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)

--车间表
create table base_workshop
(
	id int identity(1,1) primary key not null,--主键
	name nvarchar(100) not null default(''),--车间名称
	isenable bit not null default(0),--是否禁用
	remark nvarchar(300),--备注说明
	create_time datetime not null default(getdate()),--创建时间
	create_username nvarchar(40) not null,--添加用户
)


--施工单表
create table erp_construction
(
	id int identity(1,1) not null,--主键
	no nvarchar(100) not null primary key,--TO00001
	product_id int not null,--产品编号
	product_name nvarchar(100) not null,--产品名称
	customer_no nvarchar(100) not null,--客户编号
	customer_name nvarchar(100) not null,--客户名称
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
	id uniqueidentifier primary key not null,
	con_no nvarchar(50) not null,--施工单编号
	parts_id int not null,--部件编号
	parts_name nvarchar(100) not null,--部件名称
	parts_guige nvarchar(100) not null,--部件规格
	number int not null,--生产数量
	state int not null,--状态 0待确认 --1待生产,2生产中,3已完成
	remarrk nvarchar(max),--备注
)

--部件生产工序表
create table erp_process
(
	id uniqueidentifier primary key not null,
	con_no nvarchar(200) not null,--施工单编号
	erp_parts_id uniqueidentifier not null,--所属部件
	process_id int not null,--工序编号
	process_name nvarchar(100) not null,--工序名称 
	sort int not null,--排序号
	number int not null,--计划生产数量
	is_waifa bit not null default(0),--是否外发
	unit nvarchar(20) not null,--单位
	panel nvarchar(100),--板材信息
	remarrk nvarchar(max),--工序要求
)

--部件材料表
create table erp_material
(
	id int identity(1,1) not null,--主键
	con_no nvarchar(100) not null,--施工单编号
	erp_parts_id uniqueidentifier not null,--所属部件
	material_no nvarchar(50) not null,--物料编号
	material_name nvarchar(100) not null,--编号名称
	is_waifadailiao bit not null default(0),--是否是外发带料
	number int,--需求数量
	unit nvarchar(20) not null,--单位
	remarrk nvarchar(max),--备注
)

create table erp_workorder
(
	id int identity(1,1) not null,--主键
	no nvarchar(50) primary key not null,--工单号MO0001
	con_no nvarchar(50) not null,--施工单编号
	product_name nvarchar(50) not null,--产品名称
	delivery_date date not null,--交货日期
	erp_parts_id uniqueidentifier not null,--部件单据ID
	parts_id int not null,--部件ID
	parts_name nvarchar(50) not null,--部件名称
	erp_process_id uniqueidentifier not null,--工序单据ID
	process_id int not null,--工序ID
	process_name nvarchar(50) not null,--工序名称
	panel nvarchar(100),--板材信息
	number int not null,--需求数量
	practical_number int,--已生产数量
	loss_number int,--累加损耗数量
	unit nvarchar(20) not null,--单位
	workshop_id int,--排产生产车间ID
	workshop_name nvarchar(50),--车间名称
	remarrk nvarchar(max),--部件备注+工序备注
	state int not null,--状态 0待排产,1,待生产,2生产中,3已完成
	arrange_username nvarchar(40),--安排人
	arrange_time datetime,--排产时间
	complete_username nvarchar(40),--完工确认人
	complete_time datetime,--完工时间
	create_time datetime not null default(getdate()),--开单时间
	create_username nvarchar(40) not null,--开单用户
)

--生产报产表
create table erp_workorder_produce
(
	id int identity(1,1) not null,--主键
	workorder_no nvarchar(50) not null,
	product_name nvarchar(50) not null,--产品名称
	parts_name nvarchar(50) not null,--部件名称
	process_name nvarchar(50) not null,--工序名称
	number int not null,--需求数量
	produce_number int not null,--生产数量
	warehouse_id int,--仓库
	warehouse_name nvarchar(50),--仓库
	area_id int,--库区
	area_name nvarchar(50),--库区
	location_id int,--具体位置
	location_name int,--具体位置
	create_time datetime not null default(getdate()),--报产时间
	create_username nvarchar(40) not null,--报产用户
)


--外发单表
create table erp_outsource
(
	id int identity(1,1) not null,--主键
	no nvarchar(100) not null default('') primary key,--WO00001
	source_no nvarchar(50),--源数据编号
	supplier_id int not null,--供应商编号
	supplier_name int not null,--供应商名称
	delivery_date date not null,--交货日期
	parts_id int not null,--部件ID
	parts_name nvarchar(50) not null,--部件名称
	process_id int not null,--工序ID
	process_name nvarchar(50) not null,--工序名称
	number int not null,--需求数量
	price decimal(10,4) not null,--采购单价
	account decimal(10,2) not null,--总金额
	unit nvarchar(20) not null,--单位
	remarrk nvarchar(max),--部件备注+工序备注
	state int not null,--状态 0待确认,1,已确认,2入库;
	create_time datetime not null default(getdate()),--开单时间
	create_username nvarchar(40) not null,--开单用户
)

--采购订单表
create table erp_purchase
(
	id int identity(1,1) not null,--主键
	no nvarchar(100) not null default('') primary key,--PO00001
	source_no nvarchar(50),--源数据编号
	type int not null,--采购类型 1生产采购 2办公采购 3
	supplier_id int not null,--供应商编号
	supplier_name int not null,--供应商名称
	delivery_date date not null,--交货日期
	parts_id int not null,--部件ID
	parts_name nvarchar(50) not null,--部件名称
	process_id int not null,--工序ID
	process_name nvarchar(50) not null,--工序名称
	number int not null,--需求数量
	price decimal(10,4) not null,--采购单价
	account decimal(10,2) not null,--总金额
	unit nvarchar(20) not null,--单位
	remarrk nvarchar(max),--部件备注+工序备注
	state int not null,--状态 0待确认,1,已确认,2入库;
	arrange_username nvarchar(40),--安排人
	create_time datetime not null default(getdate()),--开单时间
	create_username nvarchar(40) not null,--开单用户
)

--采购附表
create table erp_purchase_detail
(
	id int identity(1,1) not null,--主键
	erp_purchase_no varchar(50) not null,--主表记录
)

--入库单表
create table erp_storage
(
	id int identity(1,1) not null,--主键
	no nvarchar(100) not null default('') primary key,--HO00001
	source_no nvarchar(50) not null,--源数据
	type int not null,--类型1成品 2外发 3采购
	in_no int not null,--ID
	in_name nvarchar(100) not null,--入库名称
	number int not null,--入库数量
	unit nvarchar(20) not null,--单位
	warehouse_id int not null,--仓库id
	warehouse_name nvarchar(100) not null,--仓库name
	aera_id int not null,--仓库-区域ID
	aera_name nvarchar(100) not null,--仓库-区域名称
	location_id int not null,--对应货架id
	location_name int not null,--对应货架
	state int not null,--状态 0待确认,1,已确认,2入库;
	create_time datetime not null default(getdate()),--操作时间
	create_username nvarchar(40) not null,--操作用户
)

--库存表
create table erp_inventory
(
	id int identity(1,1) not null,--主键
	type int not null,--类型1成品 2物料 3部件
	in_no int not null,--ID
	in_name nvarchar(100) not null,--产品名称
	number int not null,--数量
	create_time datetime not null default(getdate()),--时间
	create_username nvarchar(40) not null,--操作用户
)




