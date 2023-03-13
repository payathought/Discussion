/**
 * Kendo UI v2023.1.117 (http://www.telerik.com/kendo-ui)
 * Copyright 2023 Progress Software Corporation and/or one of its subsidiaries or affiliates. All rights reserved.
 *
 * Kendo UI commercial licenses may be obtained at
 * http://www.telerik.com/purchase/license-agreement/kendo-ui-complete
 * If you do not own a commercial license, this file shall be governed by the trial license terms.
 */
import"./kendo.data.js";import"./kendo.userevents.js";import"./kendo.mobile.button.js";var __meta__={id:"mobile.listview",name:"ListView",category:"mobile",description:"The Kendo Mobile ListView widget is used to display flat or grouped list of items.",depends:["data","userevents","mobile.button"]};!function(t,e){var i=window.kendo,s=window.Node,n=i.mobile,o=n.ui,r=i._outerHeight,l=i.data.DataSource,a=o.DataBoundWidget,h=".km-listview-link, .km-listview-label",d="["+i.attr("icon")+"]",c=i.attrValue,u="km-group-title",f=i.template((t=>`<li><div class="km-group-title"><div class="km-text">${this.headerTemplate(t)}</div></div><ul>${i.render(this.template,t.items)}</ul></li>`)),p=i.template((({placeholder:t})=>`<form class="km-filter-form"><div class="km-filter-wrap"><input type="search" placeholder="${t}"/><a href="#" class="km-filter-reset" title="Clear"><span class="km-icon km-clear"></span><span class="km-text">Clear</span></a></div></form>`)),m=".kendoMobileListView",g="styled",_="dataBound",v="dataBinding",b="itemChange",w="click",k="change",S="progress",y="function",T=/^\s+$/,x=/button/;function C(){return this.nodeType===s.TEXT_NODE&&this.nodeValue.match(T)}function I(t,e){e&&!t[0].querySelector(".km-icon")&&t.prepend('<span class="km-icon km-'+e+'"/>')}function H(e,i){t(e).css("transform","translate3d(0px, "+i+"px, 0px)")}var B=i.Class.extend({init:function(t){var e=t.scroller();if(e){this.options=t.options,this.element=t.element,this.scroller=t.scroller(),this._shouldFixHeaders();var i=this,s=function(){i._cacheHeaders()};t.bind("resize",s),t.bind(g,s),t.bind(_,s),this._scrollHandler=function(t){i._fixHeader(t)},e.bind("scroll",this._scrollHandler)}},destroy:function(){var t=this;t.scroller&&t.scroller.unbind("scroll",t._scrollHandler)},_fixHeader:function(e){if(this.fixedHeaders){var i,s,n,o=0,r=this.scroller,l=this.headers,a=e.scrollTop;do{if(!(i=l[o++])){n=t("<div />");break}s=i.offset,n=i.header}while(s+1>a);this.currentHeader!=o&&(r.fixedContainer.html(n.clone()),this.currentHeader=o)}},_shouldFixHeaders:function(){this.fixedHeaders="group"===this.options.type&&this.options.fixedHeaders},_cacheHeaders:function(){if(this._shouldFixHeaders(),this.fixedHeaders){var e=[],i=this.scroller.scrollTop;this.element.find("."+u).each((function(s,n){n=t(n),e.unshift({offset:n.position().top+i,header:n})})),this.headers=e,this._fixHeader({scrollTop:i})}}}),D=function(){return{page:1}},z=i.Class.extend({init:function(t){var e=this,i=t.options,s=t.scroller(),n=i.pullParameters||D;this.listView=t,this.scroller=s,t.bind("_dataSource",(function(t){e.setDataSource(t.dataSource)})),s.setOptions({pullToRefresh:!0,pull:function(){e._pulled||(e._pulled=!0,e.dataSource.read(n.call(t,e._first)))},messages:{pullTemplate:i.messages.pullTemplate,releaseTemplate:i.messages.releaseTemplate,refreshTemplate:i.messages.refreshTemplate}})},setDataSource:function(t){var e=this;this._first=t.view()[0],this.dataSource=t,t.bind("change",(function(){e._change()})),t.bind("error",(function(){e._change()}))},_change:function(){var t=this.scroller,e=this.dataSource;if(this._pulled&&t.pullHandled(),this._pulled||!this._first){var i=e.view();i[0]&&(this._first=i[0])}this._pulled=!1}}),V=i.Observable.extend({init:function(t){var e=this;i.Observable.fn.init.call(e),e.buffer=t.buffer,e.height=t.height,e.item=t.item,e.items=[],e.footer=t.footer,e.buffer.bind("reset",(function(){e.refresh()}))},refresh:function(){for(var t=this.buffer,e=this.items,i=!1;e.length;)e.pop().destroy();this.offset=t.offset;for(var s,n,o=this.item,r=0;r<t.viewSize;r++){if(r===t.total()){i=!0;break}(n=o(this.content(this.offset+e.length))).below(s),s=n,e.push(n)}this.itemCount=e.length,this.trigger("reset"),this._resize(),i&&this.trigger("endReached")},totalHeight:function(){if(!this.items[0])return 0;var t=this,e=t.items,i=e[0].top,s=e[e.length-1].bottom,n=(s-i)/t.itemCount,o=t.buffer.length-t.offset-t.itemCount;return(this.footer?this.footer.height:0)+s+o*n},batchUpdate:function(t){var e,i=this.height(),s=this.items,n=this.offset;if(s[0]){if(this.lastDirection)for(;s[s.length-1].bottom>t+2*i&&0!==this.offset;)this.offset--,(e=s.pop()).update(this.content(this.offset)),e.above(s[0]),s.unshift(e);else for(;s[0].top<t-i;){var o=this.offset+this.itemCount;if(o===this.buffer.total()){this.trigger("endReached");break}if(o===this.buffer.length)break;(e=s.shift()).update(this.content(this.offset+this.itemCount)),e.below(s[s.length-1]),s.push(e),this.offset++}n!==this.offset&&this._resize()}},update:function(t){var e,i,s,n=this,o=this.items,r=this.height(),l=this.itemCount,a=r/2,h=(this.lastTop||0)>t,d=t-a,c=t+r+a;if(o[0])if(this.lastTop=t,this.lastDirection=h,h)o[0].top>d&&o[o.length-1].bottom>c+a&&this.offset>0&&(this.offset--,e=o.pop(),i=o[0],e.update(this.content(this.offset)),o.unshift(e),e.above(i),n._resize());else if(o[o.length-1].bottom<c&&o[0].top<d-a){var u=this.offset+l;u===this.buffer.total()?this.trigger("endReached"):u!==this.buffer.length&&(e=o.shift(),s=o[o.length-1],o.push(e),e.update(this.content(this.offset+this.itemCount)),n.offset++,e.below(s),n._resize())}},content:function(t){return this.buffer.at(t)},destroy:function(){this.unbind()},_resize:function(){var t=this.items,e=0,i=0,s=t[0],n=t[t.length-1];s&&(e=s.top,i=n.bottom),this.trigger("resize",{top:e,bottom:i}),this.footer&&this.footer.below(n)}});i.mobile.ui.VirtualList=V;var F=i.Class.extend({init:function(e,i){var s=e.append([i],!0)[0],n=s.offsetHeight;t.extend(this,{top:0,element:s,listView:e,height:n,bottom:n})},update:function(t){this.element=this.listView.setDataItem(this.element,t)},above:function(t){t&&(this.height=this.element.offsetHeight,this.top=t.top-this.height,this.bottom=t.top,H(this.element,this.top))},below:function(t){t&&(this.height=this.element.offsetHeight,this.top=t.bottom,this.bottom=this.top+this.height,H(this.element,this.top))},destroy:function(){i.destroy(this.element),t(this.element).remove()}}),L='<div><span class="km-icon"></span><span class="km-loading-left"></span><span class="km-loading-right"></span></div>',E=i.Class.extend({init:function(e){this.element=t('<li class="km-load-more km-scroller-refresh" style="display: none"></li>').appendTo(e.element),this._loadIcon=t(L).appendTo(this.element)},enable:function(){this.element.show(),this.height=r(this.element,!0)},disable:function(){this.element.hide(),this.height=0},below:function(t){t&&(this.top=t.bottom,this.bottom=this.height+this.top,H(this.element,this.top))}}),R=E.extend({init:function(e,i){this._loadIcon=t(L).hide(),this._loadButton=t('<a class="km-load">'+e.options.messages.loadMoreText+"</a>").hide(),this.element=t('<li class="km-load-more" style="display: none"></li>').append(this._loadIcon).append(this._loadButton).appendTo(e.element);var s=this;this._loadButton.kendoMobileButton().data("kendoMobileButton").bind("click",(function(){s._hideShowButton(),i.next()})),i.bind("resize",(function(){s._showLoadButton()})),this.height=r(this.element,!0),this.disable()},_hideShowButton:function(){this._loadButton.hide(),this.element.addClass("km-scroller-refresh"),this._loadIcon.css("display","block")},_showLoadButton:function(){this._loadButton.show(),this.element.removeClass("km-scroller-refresh"),this._loadIcon.hide()}}),M=i.Class.extend({init:function(t){var e=this;this.chromeHeight=r(t.wrapper.children().not(t.element)),this.listView=t,this.scroller=t.scroller(),this.options=t.options,t.bind("_dataSource",(function(t){e.setDataSource(t.dataSource,t.empty)})),t.bind("resize",(function(){e.list.items.length&&(e.scroller.reset(),e.buffer.range(0),e.list.refresh())})),this.scroller.makeVirtual(),this._scroll=function(t){e.list.update(t.scrollTop)},this.scroller.bind("scroll",this._scroll),this._scrollEnd=function(t){e.list.batchUpdate(t.scrollTop)},this.scroller.bind("scrollEnd",this._scrollEnd)},destroy:function(){this.list.unbind(),this.buffer.unbind(),this.scroller.unbind("scroll",this._scroll),this.scroller.unbind("scrollEnd",this._scrollEnd)},setDataSource:function(e,s){var n,o,r,l=this,a=this.options,h=this.listView,d=h.scroller(),c=a.loadMore;if(this.dataSource=e,!(n=e.pageSize()||a.virtualViewSize)&&!s)throw new Error("the DataSource does not have page size configured. Page Size setting is mandatory for the mobile listview virtual scrolling to work as expected.");this.buffer&&this.buffer.destroy(),o=new i.data.Buffer(e,Math.floor(n/2),c),r=c?new R(h,o):new E(h),this.list&&this.list.destroy();var u=new V({buffer:o,footer:r,item:function(t){return new F(h,t)},height:function(){return d.height()}});u.bind("resize",(function(){l.updateScrollerSize(),h.updateSize()})),u.bind("reset",(function(){l.footer.enable()})),u.bind("endReached",(function(){r.disable(),l.updateScrollerSize()})),o.bind("expand",(function(){u.lastDirection=!1,u.batchUpdate(d.scrollTop)})),t.extend(this,{buffer:o,scroller:d,list:u,footer:r})},updateScrollerSize:function(){this.scroller.virtualSize(0,this.list.totalHeight()+this.chromeHeight)},refresh:function(){this.list.refresh()},reset:function(){this.buffer.range(0),this.list.refresh()}}),$=i.Class.extend({init:function(t){var e=this;this.listView=t,this.options=t.options;var i=this;this._refreshHandler=function(t){i.refresh(t)},this._progressHandler=function(){t.showLoading()},t.bind("_dataSource",(function(t){e.setDataSource(t.dataSource)}))},destroy:function(){this._unbindDataSource()},reset:function(){},refresh:function(t){var e,i,s,n,r=t&&t.action,l=t&&t.items,a=this.listView,h=this.dataSource,d=this.options.appendOnRefresh,c=h.view(),u=h.group(),f=u&&u[0];if("itemchange"!==r)if("add"===r&&!f||d&&!a._filter?i=[]:"remove"===r&&!f&&(i=a.findByDataItem(l)),a.trigger(v,{action:r||"rebind",items:l,removedItems:i,index:t&&t.index}))this._shouldShowLoading()&&a.hideLoading();else{if("add"!==r||f)"remove"!==r||f?f?a.replaceGrouped(c):d&&!a._filter?(s=a.prepend(c),n=c):a.replace(c):(s=[],a.remove(l));else{var p=c.indexOf(l[0]);p>-1&&(s=a.insertAt(l,p),n=l)}this._shouldShowLoading()&&a.hideLoading(),a.trigger(_,{ns:o,addedItems:s,addedDataItems:n})}else a._hasBindingTarget()||(e=a.findByDataItem(l)[0])&&a.setDataItem(e,l[0])},setDataSource:function(t){this.dataSource&&this._unbindDataSource(),this.dataSource=t,t.bind(k,this._refreshHandler),this._shouldShowLoading()&&this.dataSource.bind(S,this._progressHandler)},_unbindDataSource:function(){this.dataSource.unbind(k,this._refreshHandler).unbind(S,this._progressHandler)},_shouldShowLoading:function(){var t=this.options;return!t.pullToRefresh&&!t.loadMore&&!t.endlessScroll}}),O=i.Class.extend({init:function(t){var e=this,i=t.options.filterable,s="change paste",n=this;this.listView=t,this.options=i,t.element.before(p({placeholder:i.placeholder||"Search..."})),!1!==i.autoFilter&&(s+=" keyup"),this.element=t.wrapper.find(".km-search-form"),this.searchInput=t.wrapper.find("input[type=search]").closest("form").on("submit"+m,(function(t){t.preventDefault()})).end().on("focus"+m,(function(){e._oldFilter=e.searchInput.val()})).on(s.split(" ").join(m+" ")+m,this._filterChange.bind(this)),this.clearButton=t.wrapper.find(".km-filter-reset").on(w,this._clearFilter.bind(this)).hide(),this._dataSourceChange=this._refreshInput.bind(this),t.bind("_dataSource",(function(t){t.dataSource.bind("change",n._dataSourceChange)}))},_refreshInput:function(){var t=this.listView.dataSource.filter(),e=this.listView._filter.searchInput;t&&t.filters[0].field===this.listView.options.filterable.field?e.val(t.filters[0].value):e.val("")},_search:function(t){this._filter=!0,this.clearButton[t?"show":"hide"](),this.listView.dataSource.filter(t)},_filterChange:function(t){var e=this;"paste"==t.type&&!1!==this.options.autoFilter?setTimeout((function(){e._applyFilter()}),1):this._applyFilter()},_applyFilter:function(){var t=this.options,e=this.searchInput.val(),i=e.length?{field:t.field,operator:t.operator||"startswith",ignoreCase:t.ignoreCase,value:e}:null;e!==this._oldFilter&&(this._oldFilter=e,this._search(i))},_clearFilter:function(t){this.searchInput.val(""),this._search(null),t.preventDefault()}}),j=a.extend({init:function(t,e){var s=this;a.fn.init.call(this,t,e),t=this.element,(e=this.options).scrollTreshold&&(e.scrollThreshold=e.scrollTreshold),t.on("down",h,"_highlight").on("move up cancel",h,"_dim"),this._userEvents=new i.UserEvents(t,{fastTap:!0,filter:".km-list > li, > li:not(.km-group-container)",allowSelection:!0,tap:function(t){s._click(t)}}),t.css("-ms-touch-action","auto"),t.wrap('<div class="km-listview-wrapper"></div>'),this.wrapper=this.element.parent(),this._headerFixer=new B(this),this._itemsCache={},this._templates(),this.virtual=e.endlessScroll||e.loadMore,this._style(),this.options.$angular&&(this.virtual||this.options.pullToRefresh)?setTimeout(this._start.bind(this)):this._start()},_start:function(){var t=this.options;this.options.filterable&&(this._filter=new O(this)),this.virtual?this._itemBinder=new M(this):this._itemBinder=new $(this),this.options.pullToRefresh&&(this._pullToRefreshHandler=new z(this)),this.setDataSource(t.dataSource),this._enhanceItems(this.items()),i.notify(this,o)},events:[w,v,_,b],options:{name:"ListView",style:"",type:"flat",autoBind:!0,fixedHeaders:!1,template:t=>i.htmlEncode(t),headerTemplate:({value:t})=>`<span class="km-text">${i.htmlEncode(t)}</span>`,appendOnRefresh:!1,loadMore:!1,endlessScroll:!1,scrollThreshold:30,pullToRefresh:!1,messages:{loadMoreText:"Press to load more",pullTemplate:"Pull to refresh",releaseTemplate:"Release to refresh",refreshTemplate:"Refreshing"},pullOffset:140,filterable:!1,virtualViewSize:null},refresh:function(){this._itemBinder.refresh()},reset:function(){this._itemBinder.reset()},setDataSource:function(t){var e=!t;this.dataSource=l.create(t),this.trigger("_dataSource",{dataSource:this.dataSource,empty:e}),this.options.autoBind&&!e&&(this.items().remove(),this.dataSource.fetch())},destroy:function(){a.fn.destroy.call(this),i.destroy(this.element),this._userEvents.destroy(),this._itemBinder&&this._itemBinder.destroy(),this._headerFixer&&this._headerFixer.destroy(),this.element.unwrap(),delete this.element,delete this.wrapper,delete this._userEvents},items:function(){return"group"===this.options.type?this.element.find(".km-list").children():this.element.children().not(".km-load-more")},scroller:function(){return this._scrollerInstance||(this._scrollerInstance=this.element.closest(".km-scroll-wrapper").data("kendoMobileScroller")),this._scrollerInstance},showLoading:function(){var t=this.view();t&&t.loader&&t.loader.show()},hideLoading:function(){var t=this.view();t&&t.loader&&t.loader.hide()},insertAt:function(t,e,i){var s=this;return s._renderItems(t,(function(n){if(0===e?s.element.prepend(n):-1===e?s.element.append(n):s.items().eq(e-1).after(n),i)for(var r=0;r<n.length;r++)s.trigger(b,{item:n.eq(r),data:t[r],ns:o})}))},append:function(t,e){return this.insertAt(t,-1,e)},prepend:function(t,e){return this.insertAt(t,0,e)},replace:function(t){return this.options.type="flat",this._angularItems("cleanup"),i.destroy(this.element.children()),this.element.empty(),this._userEvents.cancel(),this._style(),this.insertAt(t,0)},replaceGrouped:function(e){this.options.type="group",this._angularItems("cleanup"),this.element.empty();var s=t(i.render(this.groupTemplate,e));this._enhanceItems(s.children("ul").children("li")),this.element.append(s),n.init(s),this._style(),this._angularItems("compile")},remove:function(t){var e=this.findByDataItem(t);this.angular("cleanup",(function(){return{elements:e}})),i.destroy(e),e.remove()},findByDataItem:function(t){for(var e=[],s=0,n=t.length;s<n;s++)e[s]="[data-"+i.ns+"uid="+t[s].uid+"]";return this.element.find(e.join(","))},setDataItem:function(e,s){var n=this;return this._renderItems([s],(function(r){var l=t(r[0]);i.destroy(e),n.angular("cleanup",(function(){return{elements:[t(e)]}})),t(e).replaceWith(l),n.trigger(b,{item:l,data:s,ns:o})}))[0]},updateSize:function(){this._size=this.getSize()},_renderItems:function(e,s){var o=t(i.render(this.template,e));return s(o),this.angular("compile",(function(){return{elements:o,data:e.map((function(t){return{dataItem:t}}))}})),n.init(o),this._enhanceItems(o),o},_dim:function(t){this._toggle(t,!1)},_highlight:function(t){this._toggle(t,!0)},_toggle:function(e,i){if(!(e.which>1)){var s=t(e.currentTarget),n=s.parent(),o=!(c(s,"role")||"").match(x),r=e.isDefaultPrevented();o&&n.toggleClass("km-state-active",i&&!r)}},_templates:function(){var t=this.options.template,e=this.options.headerTemplate,s={},n={};s.template=typeof t===y?t:i.template(t),this.template=i.template((t=>`<li${t[0].uid?` data-uid="${t[0].uid}"`:""}>${this.template(t)}</li>`)).bind(s),n.template=this.template,n._headerTemplate=typeof e===y?e:i.template(e),n.headerTemplate=i.template((t=>this._headerTemplate(t))),this.groupTemplate=f.bind(n)},_click:function(e){if(!(e.event.which>1||e.event.isDefaultPrevented())){var s,n=e.target,r=t(e.event.target),l=r.closest(i.roleSelector("button","detailbutton","backbutton")),a=i.widgetInstance(l,o),h=n.attr(i.attr("uid"));h&&(s=this.dataSource.getByUid(h)),this.trigger(w,{target:r,item:n,dataItem:s,button:a})&&e.preventDefault()}},_styleGroups:function(){var e=this.element.children();e.children("ul").addClass("km-list"),e.each((function(){var e=t(this),i=e.contents().first();e.addClass("km-group-container"),i.is("ul")||i.is("div."+u)||i.wrap('<div class="km-group-title"><div class="km-text"></div></div>')}))},_style:function(){var t=this.options,e="group"===t.type,i=this.element,s="inset"===t.style;i.addClass("km-listview").toggleClass("km-list",!e).toggleClass("km-virtual-list",this.virtual).toggleClass("km-listinset",!e&&s).toggleClass("km-listgroup",e&&!s).toggleClass("km-listgroupinset",e&&s),i.parents(".km-listview")[0]||i.closest(".km-content").toggleClass("km-insetcontent",s),e&&this._styleGroups(),this.trigger(g)},_enhanceItems:function(e){e.each((function(){var e,s=t(this),n=!1;s.children().each((function(){var s;(e=t(this)).is("a")?(!function(t){var e=t.parent(),s=t.add(e.children(i.roleSelector("detailbutton")));e.contents().not(s).not(C).length||(t.addClass("km-listview-link").attr(i.attr("role"),"listview-link"),I(t,c(e,"icon")),I(t,c(t,"icon")))}(e),n=!0):e.is("label")&&((s=e)[0].querySelector("input[type=checkbox],input[type=radio]")&&(s.parent().contents().not(s).not((function(){return 3==this.nodeType}))[0]||(s.addClass("km-listview-label"),s.children("[type=checkbox],[type=radio]").addClass("km-widget km-icon km-check"))),n=!0)})),n||function(t){I(t,c(t,"icon")),I(t,c(t.children(d),"icon"))}(s)}))}});o.plugin(j)}(window.kendo.jQuery);
//# sourceMappingURL=kendo.mobile.listview.js.map
