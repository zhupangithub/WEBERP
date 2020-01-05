/**
* 模块名：mms viewModel
* 程序名: location.js
* Copyright(c) 2013-2015 liuhuisheng [ liuhuisheng.xm@gmail.com ] 
**/

var viewModel = function () {
    var self = this;
    this.grid = {
        size: { w: 239, h: 40 },
        url: "/api/erp/location",
        queryParams: ko.observable(),
        pagination: true
    };
    this.gridEdit = new com.editGridViewModel(this.grid);
    this.grid.onClickRow = self.gridEdit.begin;
    this.grid.OnAfterCreateEditor = function (edt) {
        com.readOnlyHandler('input')(edt["create_time"].target, true);
        com.readOnlyHandler('input')(edt["create_username"].target, true);
        com.readOnlyHandler('input')(edt["aname"].target, true);
        com.readOnlyHandler('input')(edt["wname"].target, true);
    };
    this.tree = {
        method: 'GET',
        url: '/api/erp/location/GetTypes',
        queryParams: ko.observable(),
        loadFilter: function (d) {
            var filter = utils.filterProperties(d.rows || d, ['id as id', 'name as text']);
            var data = utils.toTreeData(filter, 'id', 'pid', "children");
            return [{ id: '', text: '全部', children: data }];
        },
        onSelect: function (node) {
            self.CodeType(node);
        }
    };

    this.CodeType = ko.observable();
    this.CodeType.subscribe(function (value) {
        var value1 = "";
        if (value.id != "") {
            var str = value.id.split("+");
            value1 = str[0];
        }
        self.grid.queryParams({ area_id: value1 });
    });

    this.refreshClick = function () {
        window.location.reload();
    };
    this.addClick = function () {
        if (!self.CodeType()) return com.message('warning', '请先在左边选择要添加的仓库！');
        var data = self.CodeType();
        var str = data.id.split("+");
        var str2 = data.text.split("->");
        var value1 = str[0];
        var value2 = str[1];
        var value_text1 = str2[0];
        var value_text2 = str2[1];
        var row = { area_id: value1, warehouse_id: value2, wname: value_text1, aname: value_text2 };
        self.gridEdit.addnew(row);
    };
    this.editClick = function () {
        var row = self.grid.treegrid('getSelected');
        self.gridEdit.begin(row);
    };
    this.deleteClick = self.gridEdit.deleterow;
    this.saveClick = function () {
        self.gridEdit.ended();
        var post = { list: self.gridEdit.getChanges() };
        if (self.gridEdit.isChangedAndValid()) {
            com.ajax({
                url: '/api/erp/location/edit',
                data: ko.toJSON(post),
                success: function (d) {
                    com.message('success', '保存成功！');
                    self.gridEdit.accept();
                }
            });
        }
    };
};