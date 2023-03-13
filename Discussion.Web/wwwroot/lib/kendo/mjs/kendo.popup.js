/**
 * Kendo UI v2023.1.117 (http://www.telerik.com/kendo-ui)
 * Copyright 2023 Progress Software Corporation and/or one of its subsidiaries or affiliates. All rights reserved.
 *
 * Kendo UI commercial licenses may be obtained at
 * http://www.telerik.com/purchase/license-agreement/kendo-ui-complete
 * If you do not own a commercial license, this file shall be governed by the trial license terms.
 */
import"./kendo.core.js";var __meta__={id:"popup",name:"Pop-up",category:"framework",depends:["core"],advanced:!0};!function(e,t){var o=window.kendo,i=o.ui,n=i.Widget,s=o.Class,r=o.support,a=o.getOffset,l=o._outerWidth,d=o._outerHeight,p="open",c="close",f="deactivate",u="activate",h="center",m="right",g="top",v="bottom",b="absolute",_="hidden",w="body",y="location",k="position",x="visible",z="effects",T="k-active",C="k-state-border",P=/k-state-border-(\w+)/,S=".k-picker-wrap, .k-dropdown-wrap, .k-link",E=e(document.documentElement),I=e(window),O="scroll",R=r.transitions.css+"transform",A=e.extend,D=".kendoPopup",N=["font-size","font-family","font-stretch","font-style","font-weight","line-height"];function F(t,o){return!(!t||!o)&&(t===o||e.contains(t,o))}var H=n.extend({init:function(t,i){var s,a=this;(i=i||{}).isRtl&&(i.origin=i.origin||"bottom right",i.position=i.position||"top right"),n.fn.init.call(a,t,i),t=a.element,i=a.options,a.collisions=i.collision?i.collision.split(" "):[],a.downEvent=o.applyEventMap("down",o.guid()),1===a.collisions.length&&a.collisions.push(a.collisions[0]),s=e(a.options.anchor).closest(".k-popup,.k-group").filter(":not([class^=km-])"),i.appendTo=e(e(i.appendTo)[0]||s[0]||document.body),a.element.hide().addClass("k-popup k-group k-reset").toggleClass("k-rtl",!!i.isRtl).css({position:b}).appendTo(i.appendTo).attr("aria-hidden",!0).on("mouseenter"+D,(function(){a._hovered=!0})).on("wheel"+D,(function(t){var o=e(t.target).find(".k-list"),i=o.parent();o.length&&o.is(":visible")&&(0===i.scrollTop()&&t.originalEvent.deltaY<0||i.scrollTop()===i.prop("scrollHeight")-i.prop("offsetHeight")&&t.originalEvent.deltaY>0)&&t.preventDefault()})).on("mouseleave"+D,(function(){a._hovered=!1})),a.wrapper=e(),!1===i.animation&&(i.animation={open:{effects:{}},close:{hide:!0,effects:{}}}),A(i.animation.open,{complete:function(){a.wrapper.css({overflow:x}),a._activated=!0,a._trigger(u)}}),A(i.animation.close,{complete:function(){a._animationClose()}}),a._mousedownProxy=function(e){a._mousedown(e)},r.mobileOS.android?a._resizeProxy=function(e){setTimeout((function(){a._resize(e)}),600)}:a._resizeProxy=function(e){a._resize(e)},i.toggleTarget&&e(i.toggleTarget).on(i.toggleEvent+D,a.toggle.bind(a))},events:[p,u,c,f],options:{name:"Popup",toggleEvent:"click",origin:"bottom left",position:"top left",anchor:w,appendTo:null,collision:"flip fit",viewport:window,copyAnchorStyles:!0,autosize:!1,modal:!1,adjustSize:{width:0,height:0},animation:{open:{effects:"slideIn:down",transition:!0,duration:200},close:{duration:100,hide:!0}},omitOriginOffsets:!1},_animationClose:function(){var e=this,t=e.wrapper.data(y);e.wrapper.hide(),t&&e.wrapper.css(t),e.options.anchor!=w&&e._hideDirClass(),e._closing=!1,e._trigger(f)},destroy:function(){var t,i=this,s=i.options,r=i.element.off(D);n.fn.destroy.call(i),s.toggleTarget&&e(s.toggleTarget).off(D),s.modal||(E.off(i.downEvent,i._mousedownProxy),i._toggleResize(!1)),o.destroy(i.element.children()),r.removeData(),s.appendTo[0]===document.body&&((t=r.parent(".k-animation-container"))[0]?t.remove():r.remove())},open:function(i,n){var s,a,l=this,d={isFixed:!isNaN(parseInt(n,10)),x:i,y:n},c=l.element,f=l.options,u=e(f.anchor),h=c[0]&&c.hasClass("km-widget"),m=c.find("[role='listbox']");if(!l.visible()){if(f.copyAnchorStyles&&(h&&"font-size"==N[0]&&N.shift(),c.css(o.getComputedStyles(u[0],N))),c.data("animating")||l._trigger(p))return;l._activated=!1,f.modal||(E.off(l.downEvent,l._mousedownProxy).on(l.downEvent,l._mousedownProxy),l._toggleResize(!1),l._toggleResize(!0)),l.wrapper=a=o.wrap(c,f.autosize).css({overflow:_,display:"block",position:b}).attr("aria-hidden",!1),m.attr("aria-label")?a.attr("aria-label",m.attr("aria-label")):m.attr("aria-labelledby")&&a.attr("aria-labelledby",m.attr("aria-labelledby")),r.mobileOS.android&&a.css(R,"translatez(0)"),a.css(k),e(f.appendTo)[0]==document.body&&a.css(g,"-10000px"),l.flipped=l._position(d),s=l._openAnimation(),f.anchor!=w&&l._showDirClass(s),c.is(":visible")||c.data("olddisplay")!==t||(c.show(),c.data("olddisplay",c.css("display")),c.hide()),c.data(z,s.effects).kendoStop(!0).kendoAnimate(s).attr("aria-hidden",!1)}},_location:function(t){var i,n=this,s=n.element,a=n.options,l=e(a.anchor),d=s[0]&&s.hasClass("km-widget");a.copyAnchorStyles&&(d&&"font-size"==N[0]&&N.shift(),s.css(o.getComputedStyles(l[0],N))),n.wrapper=i=o.wrap(s,a.autosize).css({overflow:_,display:"block",position:b}),r.mobileOS.android&&i.css(R,"translatez(0)"),i.css(k),e(a.appendTo)[0]==document.body&&i.css(g,"-10000px"),n._position(t||{});var p=i.offset();return{width:o._outerWidth(i),height:o._outerHeight(i),left:p.left,top:p.top}},_openAnimation:function(){var e=A(!0,{},this.options.animation.open);return e.effects=o.parseEffects(e.effects,this.flipped),e},_hideDirClass:function(){var t=e(this.options.anchor),i=((t.attr("class")||"").match(P)||["","down"])[1],n=C+"-"+i;t.removeClass(n).children(S).removeClass(T).removeClass(n),this.element.removeClass(C+"-"+o.directions[i].reverse)},_showDirClass:function(t){var i=t.effects.slideIn?t.effects.slideIn.direction:"down",n=C+"-"+i;e(this.options.anchor).addClass(n).children(S).addClass(T).addClass(n),this.element.addClass(C+"-"+o.directions[i].reverse)},position:function(){this.visible()&&(this.flipped=this._position())},toggle:function(){this[this.visible()?c:p]()},visible:function(){return this.element.is(":visible")},close:function(t){var i,n,s,r,a=this,l=a.options;if(a.visible()){if(i=a.wrapper[0]?a.wrapper:o.wrap(a.element).hide(),a._toggleResize(!1),a._closing||a._trigger(c))return void a._toggleResize(!0);a.element.find(".k-popup").each((function(){var o=e(this).data("kendoPopup");o&&o.close(t)})),E.off(a.downEvent,a._mousedownProxy),t?n={hide:!0,effects:{}}:(n=A(!0,{},l.animation.close),s=a.element.data(z),!(r=n.effects)&&!o.size(r)&&s&&o.size(s)&&(n.effects=s,n.reverse=!0),a._closing=!0),a.element.kendoStop(!0).attr("aria-hidden",!0),i.css({overflow:_}).attr("aria-hidden",!0),a.element.kendoAnimate(n),t&&a._animationClose()}},_trigger:function(e){return this.trigger(e,{type:e})},_resize:function(e){var t=this;-1!==r.resize.indexOf(e.type)?(clearTimeout(t._resizeTimeout),t._resizeTimeout=setTimeout((function(){t._position(),t._resizeTimeout=null}),50)):(!t._hovered||t._activated&&t.element.find(".k-list").length>0)&&t.close()},_toggleResize:function(e){var t=e?"on":"off",o=r.resize;r.mobileOS.ios||r.mobileOS.android||r.browser.safari||(o+=" scroll"),e&&!this.scrollableParents&&(this.scrollableParents=this._scrollableParents()),this.scrollableParents&&this.scrollableParents.length&&this.scrollableParents[t](O,this._resizeProxy),I[t](o,this._resizeProxy)},_mousedown:function(t){var i=this,n=i.element[0],s=i.options,r=e(s.anchor)[0],a=s.toggleTarget,l=o.eventTarget(t),d=e(l).closest(".k-popup"),p=d.parent().parent(".km-shim").length;d=d[0],!p&&d&&d!==i.element[0]||"popover"!==e(t.target).closest("a").data("rel")&&(F(n,l)||F(r,l)||a&&F(e(a)[0],l)||i.close())},_fit:function(e,t,o){var i=0;return e+t>o&&(i=o-(e+t)),e<0&&(i=-e),i},_flip:function(e,t,o,i,n,s,r){var a=0;return r=r||t,s!==n&&s!==h&&n!==h&&(e+r>i&&(a+=-(o+t)),e+a<0&&(a+=o+t)),a},_scrollableParents:function(){return e(this.options.anchor).parentsUntil("body").filter((function(e,t){return o.isScrollable(t)}))},_position:function(t){var i,n,s,p,c,f,u,h=this,m=h.element,g=h.wrapper,v=h.options,_=e(v.viewport),w=r.zoomLevel(),x=!!(_[0]==window&&window.innerWidth&&w<=1.02),z=e(v.anchor),T=v.origin.toLowerCase().split(" "),C=v.position.toLowerCase().split(" "),P=h.collisions,S=10002,E=0,I=document.documentElement;(c=v.viewport===window?{top:window.pageYOffset||document.documentElement.scrollTop||0,left:window.pageXOffset||document.documentElement.scrollLeft||0}:_.offset(),x?(f=window.innerWidth,u=window.innerHeight):(f=_.width(),u=_.height()),x&&I.scrollHeight-I.clientHeight>0)&&(f-=(v.isRtl?-1:1)*o.support.scrollbar());if((i=z.parents().filter(g.siblings()))[0])if(s=Math.max(Number(i.css("zIndex")),0))S=s+10;else for(p=(n=z.parentsUntil(i)).length;E<p;E++)(s=Number(e(n[E]).css("zIndex")))&&S<s&&(S=s+10);g.css("zIndex",S),t&&t.isFixed?g.css({left:t.x,top:t.y}):g.css(h._align(T,C));var O=a(g,k,z[0]===g.offsetParent()[0]),R=a(g);z.offsetParent().parent(".k-animation-container,.k-popup,.k-group").length&&(O=a(g,k,!0),R=a(g)),R.top-=c.top,R.left-=c.left,h.wrapper.data(y)||g.data(y,A({},O));var D=A({},R),N=A({},O),F=v.adjustSize;"fit"===P[0]&&(N.top+=h._fit(D.top,d(g)+F.height,u/w)),"fit"===P[1]&&(N.left+=h._fit(D.left,l(g)+F.width,f/w));var H=A({},N),W=d(m),j=d(g);return!g.height()&&W&&(j+=W),"flip"===P[0]&&(N.top+=h._flip(D.top,W,d(z),u/w,T[0],C[0],j)),"flip"===P[1]&&(N.left+=h._flip(D.left,l(m),l(z),f/w,T[1],C[1],l(g))),m.css(k,b),g.css(N),N.left!=H.left||N.top!=H.top},_align:function(t,o){var i,n=this,s=n.wrapper,r=e(n.options.anchor),p=t[0],c=t[1],f=o[0],u=o[1],g=a(r),b=e(n.options.appendTo),_=l(s),w=d(s)||d(s.children().first()),y=l(r),k=d(r),x=n.options.omitOriginOffsets?0:g.top,z=n.options.omitOriginOffsets?0:g.left,T=Math.round;return b[0]!=document.body&&(x-=(i=a(b)).top,z-=i.left),p===v&&(x+=k),p===h&&(x+=T(k/2)),f===v&&(x-=w),f===h&&(x-=T(w/2)),c===m&&(z+=y),c===h&&(z+=T(y/2)),u===m&&(z-=_),u===h&&(z-=T(_/2)),{top:x,left:z}}});i.plugin(H);var W=o.support.stableSort,j="kendoTabKeyTrap",L=s.extend({init:function(t){this.element=e(t),this.element.autoApplyNS(j)},trap:function(){this.element.on("keydown",this._keepInTrap.bind(this))},removeTrap:function(){this.element.kendoDestroy(j)},destroy:function(){this.element.kendoDestroy(j),this.element=t},shouldTrap:function(){return!0},_keepInTrap:function(e){if(9===e.which&&this.shouldTrap()&&!e.isDefaultPrevented()){var t=this._focusableElements(),o=this._sortFocusableElements(t),i=this._nextFocusable(e,o);this._focus(i),e.preventDefault()}},_focusableElements:function(){var t=this.element.find("a[href], area[href], input:not([disabled]), select:not([disabled]), textarea:not([disabled]), button:not([disabled]), iframe, object, embed, [tabindex], *[contenteditable]").filter((function(t,o){return o.tabIndex>=0&&e(o).is(":visible")&&!e(o).is("[disabled]")}));return this.element.is("[tabindex]")&&t.push(this.element[0]),t},_sortFocusableElements:function(e){var t;if(W)t=e.sort((function(e,t){return e.tabIndex-t.tabIndex}));else{var o="__k_index";e.each((function(e,t){t.setAttribute(o,e)})),t=e.sort((function(e,t){return e.tabIndex===t.tabIndex?parseInt(e.getAttribute(o),10)-parseInt(t.getAttribute(o),10):e.tabIndex-t.tabIndex})),e.removeAttr(o)}return t},_nextFocusable:function(e,t){var o=t.length,i=t.index(e.target);return t.get((i+(e.shiftKey?-1:1))%o)},_focus:function(e){"IFRAME"!=e.nodeName?(e.focus(),"INPUT"==e.nodeName&&e.setSelectionRange&&this._haveSelectionRange(e)&&e.setSelectionRange(0,e.value.length)):e.contentWindow.document.body.focus()},_haveSelectionRange:function(e){var t=e.type.toLowerCase();return"text"===t||"search"===t||"url"===t||"tel"===t||"password"===t}});i.Popup.TabKeyTrap=L}(window.kendo.jQuery);
//# sourceMappingURL=kendo.popup.js.map
