<?xml version="1.0" encoding="iso-8859-1" ?>

<xsl:stylesheet
  version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform" >
  
<!--copy all node-->
<!--
    <xsl:copy>
      <xsl:copy-of select="@*"/>
      <xsl:value-of select="."/>
	  </xsl:copy>
    -->

<!--Modify value from condition-->
<xsl:template match="fieldValue[(@name='Id_QUERY_FIELD') and (../@idx = '1')]">
  <xsl:copy>
    <xsl:copy-of select="@*"/>
    <xsl:value-of select="'TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT'"/>

  </xsl:copy>


</xsl:template>


<!--Remove fieldValue-->
<xsl:template match="fieldValue[@name='FKCONNECTI']">
</xsl:template>

<!--Insert New fieldValue at last-->
<xsl:template match="fieldValue[last()]">

  <xsl:copy>
    <xsl:copy-of select="@*"/>
    <xsl:value-of select="."/>
  </xsl:copy>

  <fieldValue name="NOVOCAMPO">o meu novo campo</fieldValue>

</xsl:template>


  </xsl:stylesheet>