<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet
 version="1.0"
 xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xs="http://www.w3.org/2001/XMLSchema"
 exclude-result-prefixes="xs xsi xsl" >


<xsl:output method="xml" encoding="UTF-8" indent="yes" omit-xml-declaration="no" />

<xsl:template match="/">

<aa>aaa</aa>


<xsl:for-each select="ExtractionResult">
			<aa>aaa</aa>
</xsl:for-each>


<bb>bbb</bb>


</xsl:template>



</xsl:stylesheet>