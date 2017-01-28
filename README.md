# B2MML.NET

[![Build status](https://ci.appveyor.com/api/projects/status/eeujp23kfr0d22cw?svg=true)](https://ci.appveyor.com/project/jpdillingham/b2mml-net)
[![Build Status](https://travis-ci.org/jpdillingham/B2MML.NET.svg?branch=master)](https://travis-ci.org/jpdillingham/B2MML.NET)
[![NuGet version](https://img.shields.io/nuget/v/B2MML.NET.svg)](https://www.nuget.org/packages/B2MML.NET/)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/jpdillingham/B2MML.NET/blob/master/LICENSE)

A .NET Class Library containing an implementation of the MESA International standards B2MML and BatchML.

Generated with the Microsoft (R) Xml Schemas/DataTypes support utility (xsd.exe) from the KPI-ML V01 schema available from the MESA website [here](https://services.mesa.org/ResourceLibrary/ShowResource/0f47758b-60f0-40c6-a71b-fa7b2363fb3a).

# About B2MML

From the MESA website:

> B2MML is an XML implementation of the ANSI/ISA-95, Enterprise-Control System Integration, family of standards (ISA-95), known internationally as IEC/ISO 62264. B2MML consists of a set of XML schemas written using the World Wide Web Consortium's XML Schema language (XSD) that implement the data models in the ISA-95 standard.

> Companies interested in following ISA-95 for integration projects may use B2MML to integrate business systems such as ERP and supply chain management systems with manufacturing systems such as control systems and manufacturing execution systems. B2MML is a complete implementation of ISA-95. Any company may use B2MML royalty free, provided credit is given to MESA.

> B2MML V0600 is the latest version. Earlier versions are still available; however, we recommend new users use the latest version which contains enhancements based upon user feedback.

# About BatchML

From the MESA website:

> BatchML is an XML implementation of the ANSI/ISA-88, Batch Control, family of standards (ISA-88), known internationally as IEC 61512. BatchML consists of a set of XML schemas written using the World Wide Web Consortium's XML Schema language (XSD) that implements the models and terminology in the ISA-88 standard.

> The ISA-88 standard is recognized worldwide as the standard for the batch processing industry. BatchML provides a set of XML type and element definitions that may be used in part or in whole for batch, master recipe, site and general recipe, production record and equipment data. BatchML is an excellent tool to use when exchanging ISA-88 based data. Any company may use BatchML royalty free, provided credit is given to MESA.

> BatchML V0600 is the latest version. Earlier versions are also available, however we recommend using the latest version which contains enhancements based upon user feedback. V0600 is a minor update for BatchML. However the version number reflects a major update since BatchML and B2MML share the same namespace and V0600 is a major release for B2MML. The only changes for BatchML in V0600 is the inclusion of the V0500 errata items and the addition of the ISA 95 Part 4 objects in Batch Production Records.