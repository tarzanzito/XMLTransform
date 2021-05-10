<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet
 version="1.0"
 xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:n="http://tempuri.org/ExtractionResult.xsd"
 xmlns:xs="http://www.w3.org/2001/XMLSchema"
 exclude-result-prefixes="xs xsi xsl" >

<xsl:namespace-alias stylesheet-prefix="n" result-prefix="#default"/>

<xsl:output method="xml" encoding="UTF-8" indent="yes" omit-xml-declaration="no" />

<xsl:template match="/n:ExtractionResult">

	<xsl:for-each select="/ExtractionResult">
			<xsl:value-of select="@name" />

<n:aa>aaa</n:aa>

	</xsl:for-each>

	
</xsl:template>

</xsl:stylesheet>
