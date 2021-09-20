[LaTeXIO](https://github.com/MutiYouth/LaTeXIO) is forked from [WordxTex](https://github.com/rylandev/WordxTex) 。 

# DEV
推荐使用VS2017进行开发。

1）下载下来代码
```bash
git clone xxx --recursive
```

2) 可以自动安装所需的开发环境 `Visual Studio 2010 Tools for Office Runtime`。
或者自行下载[Visual Studio 2010 Tools for Office Runtime](https://link.zhihu.com/?target=https%3A//www.microsoft.com/en-us/download/details.aspx%3Fid%3D48217)

3） 安装到office word 后，可以在加载项中看到LaTeXIO，并进行如下设置：
![](doc/asserts/setting.png)


# 问题与解决

* 如何调试?
  * 先在卸载和变更程序中，卸载旧的软件LaTeXIO。
  * 编译生成Debug版本的软件。
  * 在`xxxx\LaTeXIO\bin\Debug` 中，点击`LaTeXIO.vsto`安装, word的com加载项。
  * 关掉word, 在VS中，点击调试或F5，即可同时启动word，点击word 中加载项的LaTeXIO中的子项按钮，即可进入到
    相应的调试位置。
  
  备注：如果出现LaTeX被禁用的，类似下图中第一个方框中出现了LaTeXIO，则可以在第二个方框中的操作下，取消`LaTeXIO。dll`被禁用即可。
  ![](doc/asserts/was_forbaden_condiction.png)
  <br/> <br/>

* office 365 上面是灰色的，无法使用。 

  已经解决，需要安装 texlive, 并将类似的
  `xxx\LaTeX\soft_texlive_2021\texlive\2021\bin\win32` 路径加入到 windows的系统环境变量中去。



# REF
https://zhuanlan.zhihu.com/p/126710209