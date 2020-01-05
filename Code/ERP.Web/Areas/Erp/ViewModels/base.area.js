/**
* 模块名：mms viewModel
* 程序名: area.js
* Copyright(c) 2013-2015 liuhuisheng [ liuhuisheng.xm@gmail.com ] 
**/

var viewModel = function () {
    var self = this;
    this.grid = {
        size: { w: 239, h: 40 },
        url: "/api/erp/area",
        queryParams: ko.observable(),
        pagination: true
    };
    this.gridEdit = new com.editGridViewModel(this.grid);
    this.grid.onClickRow = self.gridEdit.begin;
    this.grid.OnAfterCreateEditor = function (edt) {
        com.readOnlyHandler('input')(edt["create_time"].target, true);
        com.readOnlyHandler('input')(edt["create_username"].target, true);
    };
    this.tree = {
        method:'GET',
        url: '/api/erp/area/GetTypes',
        queryParams: ko.observable(),
        loadFilter: function (d) {
            var filter = utils.filterProperties(d.rows || d, ['id as id', 'name as text']);
            var data = utils.toTreeData(filter, 'id', 'pid', "children");
            return [{ id: '', text: '所有仓库', children: data }];
        },
        onSelect: function (node) {
            self.CodeType(node.id);
        }
    };

    this.CodeType = ko.observable();
    this.CodeType.subscribe(function (value) {
        self.grid.queryParams({ warehouse_id: value });
    });

    this.refreshClick = function () {
        window.location.reload();
    };
    this.addClick = function () {
        if (!self.CodeType()) return com.message('warning', '请先在左边选择要添加的仓库！');
        var row = { warehouse_id: self.CodeType()};
        self.gridEdit.addnew(row);
    };
    this.editClick = function () {
        var row = self.grid.treegrid('getSelected');
        self.gridEdit.begin(row);
    };
    this.deleteClick = self.gridEdit.deleterow;
    this.saveClick = function () {
        self.gridEdit.ended();
        var post = {list:self.gridEdit.getChanges()};
        if (self.gridEdit.isChangedAndValid()) {
            com.ajax({
                url: '/api/erp/area/edit',
                data: ko.toJSON(post),
                success: function (d) {
                    com.message('success', '保存成功！');
                    self.gridEdit.accept();
                }
            });
        }
    };
};