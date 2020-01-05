/**
* 模块名：base viewModel
* 程序名: SearchEdit.js
* Copyright(c) 2013-2015 liuhuisheng [ liuhuisheng.xm@gmail.com ] 
**/
var base = base || {};
base.viewModel = base.viewModel || {};

base.viewModel.searchEdit = function (data) {
    var self = this;
    this.urls = data.urls;
    this.resx = data.resx;
    this.dataSource = data.dataSource;
    this.form = ko.mapping.fromJS(data.form);
    this.defaultRow = data.defaultRow;
    this.setting = data.setting;
    delete this.form.__ko_mapping__;

    this.grid = {
        size: { w: 4, h: 94 },
        url: self.urls.query,
        queryParams: ko.observable(),
        pagination: true
    };
    this.gridEdit = new com.editGridViewModel(this.grid);
    this.grid.onDblClickRow = this.gridEdit.begin;
    this.grid.onClickRow = this.gridEdit.ended;
    this.grid.OnAfterCreateEditor = function (editors) {
        com.readOnlyHandler('input')(editors.create_time.target, true);
        com.readOnlyHandler('input')(editors.create_username.target, true);
    };
    this.searchClick = function () {
        var param = ko.toJS(this.form);
        this.grid.queryParams(param);
    };
    this.clearClick = function () {
        $.each(self.form, function () { this(''); });
        this.searchClick();
    };
    this.refreshClick = function () {
        window.location.reload();
    };
    this.addClick = function () {
        var row = $.extend(self.defaultRow);
        self.gridEdit.addnew(row);
    };
    this.deleteClick = self.gridEdit.deleterow;
    this.editClick = function () {
        var row = self.grid.datagrid('getSelected');
        if (!row) return com.message('warning', self.resx.noneSelect);
        self.gridEdit.begin()
    };
    this.grid.onDblClickRow = this.editClick;
    this.auditClick = function () {
        var row = self.grid.datagrid('getSelected');
        if (!row) return com.message('warning', self.resx.noneSelect);
        com.auditDialog(function (d) {
            com.ajax({
                type: 'POST',
                url: self.urls.audit + row.BillNo,
                data: JSON.stringify(d),
                success: function () {
                    com.message('success', self.resx.auditSuccess);
                }
            });
        });
    };
    this.saveClick = function () {
        self.gridEdit.ended(); //结束grid编辑状态
        var post = {};
        post.list = self.gridEdit.getChanges(self.setting.postListFields);
        if (self.gridEdit.ended() && post.list._changed) {
            com.ajax({
                url: self.urls.edit,
                data: ko.toJSON(post),
                success: function (d) {
                    com.message('success', self.resx.editSuccess);
                    self.gridEdit.accept();
                }
            });
        }
    };
};

var userSetting = function (row) {
    if (row._isnew)
        return com.message('warning', '请先保存再维护工艺数据！');
    com.dialog({
        title: "维护部件权限",
        width: 800,
        height: 600,
        html: "#permission-template",
        viewModel: function (w) {
            var that = this;
            this.grid = {
                width: 586,
                height: 340,
                pagination: false,
                pageSize: 10,
                url: "/api/erp/parts/Getgy/" + row.id,
                queryParams: ko.observable()
            };
            this.cancelClick = function () {
                w.dialog('close');
            };
            this.gridEdit = new com.editGridViewModel(this.grid);
            this.grid.onClickRow = that.gridEdit.ended;
            this.grid.onDblClickRow = that.gridEdit.begin;
            this.grid.toolbar = [
                { text: '新增', iconCls: 'icon-add1', handler: function () { that.gridEdit.addnew({ parts_id: row.id }); } }, '-',
                { text: '编辑', iconCls: 'icon-edit', handler: that.gridEdit.begin }, '-',
                { text: '删除', iconCls: 'icon-cross', handler: that.gridEdit.deleterow }
            ];
            this.confirmClick = function () {
                if (!that.gridEdit.isChangedAndValid()) return;
                var list = that.gridEdit.getChanges(['id', 'parts_id', 'name', 'orderby', 'remark', 'create_time','create_username']);
                com.ajax({
                    url: '/api/erp/parts/Editgy',
                    data: ko.toJSON({ list: list }),
                    success: function (d) {
                        that.cancelClick();
                        com.message('success', '保存成功！');
                    }
                });
            };
        }
    });
};