<p align='center'>
<img src='https://raw.githubusercontent.com/williamniemiec/MetricsIntegrator/master/docs/img/logo/logo.png?raw=true' />
</p>

<h1 align='center'>Metrics Integrator</h1>
<p align='center'>A simple tool that uses as input the source code metrics file and the mapping between application methods and the test methods. As output, our application yields a file where each instance involves source code metrics of one test method and the particular application method under test.</p>
<p align="center">
	<a href="https://github.com/williamniemiec/MetricsIntegrator/actions/workflows/windows.yml"><img src="https://github.com/williamniemiec/MetricsIntegrator/actions/workflows/windows.yml/badge.svg" alt=""></a>
	<a href="https://github.com/williamniemiec/MetricsIntegrator/actions/workflows/macos.yml"><img src="https://github.com/williamniemiec/MetricsIntegrator/actions/workflows/macos.yml/badge.svg" alt=""></a>
	<a href="https://github.com/williamniemiec/MetricsIntegrator/actions/workflows/ubuntu.yml"><img src="https://github.com/williamniemiec/MetricsIntegrator/actions/workflows/ubuntu.yml/badge.svg" alt=""></a>
	<a href="https://codecov.io/gh/williamniemiec/MetricsIntegrator"><img src="https://codecov.io/gh/williamniemiec/MetricsIntegrator/branch/master/graph/badge.svg?token=R2SFS4SP86" alt="Coverage status"></a>
	<a href="http://java.oracle.com"><img src="https://img.shields.io/badge/.NET-5.0+-D0008F.svg" alt="Dotnet compatibility"></a>
	<a href="https://github.com/williamniemiec/MetricsIntegrator/releases"><img src="https://img.shields.io/github/v/release/williamniemiec/MetricsIntegrator" alt="Release"></a>
</p>
<hr />

## ❇ Introduction
A simple tool that uses as input the source code metrics file and the mapping between application methods and the test methods. As output, our application yields a file where each instance involves source code metrics of one test method and the particular application method under test.

We developed this tool to generate the defined metrics to build the dataset detailed in the paper "A dataset based on two graph coverage criteria: prime-path and edge coverage"

## ⚠ Requirements
- CSV separated by ';'
- First column of source code metrics and code coverage must be a method signature 

## Gallery

#### Home
![home-img](https://raw.githubusercontent.com/williamniemiec/MetricsIntegrator/master/docs/img/screens/home.png?raw=true)

#### Export selection
![export-gif](https://raw.githubusercontent.com/williamniemiec/MetricsIntegrator/master/docs/gif/screens/export.gif?raw=true)

## 🚩 Changelog
Details about each version are documented in the [releases section](https://github.com/williamniemiec/MetricsIntegrator/releases).

## 🤝 Contribute!
See the documentation on how you can contribute to the project [here](https://github.com/williamniemiec/MetricsIntegrator/blob/master/CONTRIBUTING.md).

## 📁 Files
### /
|        Name 	|Type|Description|
|----------------|-------------------------------|-----------------------------|
|dist |`Directory`|Released versions|
|docs |`Directory`|Documentation files|
|src     |`Directory`| Source files |
|test     |`Directory`| Test files |
