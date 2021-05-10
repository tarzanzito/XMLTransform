<?xml version="1.0" encoding="iso-8859-1" ?>

<xsl:stylesheet
 version="1.0"
 xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xs="http://www.w3.org/2001/XMLSchema"
 exclude-result-prefixes="xs xsi xsl" >

<xsl:output method="xml" encoding="UTF-8" indent="yes" omit-xml-declaration="no" />

  <!--/////////////////////////////////////////////////////////////-->
  
  <!--Start-->
  <xsl:template match="/">
    <xsl:apply-templates/>
  </xsl:template>

  <!--/////////////////////////////////////////////////////////////-->

  <!--ExtractionResult-->
  <xsl:template match="ExtractionResult">

	  <xsl:copy>
      <xsl:copy-of select="@*"/>
      <xsl:apply-templates/>
    </xsl:copy>

  </xsl:template>

  <!--/////////////////////////////////////////////////////////////-->

  <!--parameters-->
  <xsl:template match="parameters">

    <xsl:copy>
      <xsl:copy-of select="@*"/>
      <xsl:apply-templates/>
    </xsl:copy>

  </xsl:template>

  <!--/////////////////////////////////////////////////////////////-->

  <!--queryResult-->
  <xsl:template match="queryResult">

    <xsl:copy>
      <xsl:copy-of select="@*"/>
      <xsl:apply-templates/>
    </xsl:copy>

  </xsl:template>

  <!--/////////////////////////////////////////////////////////////-->

  <!--parameterValue-->
  <xsl:template match="parameterValue">
    
    <xsl:copy>
      <xsl:copy-of select="@*"/>
      <xsl:value-of select="."/>
    </xsl:copy>
    
  </xsl:template>


  <!--/////////////////////////////////////////////////////////////-->

  <!--rows-->
  <xsl:template match="rows">
	  
    <xsl:copy>
      <xsl:copy-of select="@*"/>
      <xsl:apply-templates/>
   	</xsl:copy>

  </xsl:template>

  <!--/////////////////////////////////////////////////////////////-->

  <!--row-->
  <xsl:template match="row">
    
    <xsl:copy>
      <xsl:copy-of select="@*"/>
      <xsl:apply-templates/>
   	</xsl:copy>

  </xsl:template>

  <!--/////////////////////////////////////////////////////////////-->

  <!--contain-->
  <xsl:template match="contain">
    
    <xsl:copy>
      <xsl:copy-of select="@*"/>
      <xsl:apply-templates/>
   	</xsl:copy>

  </xsl:template>

  <!--/////////////////////////////////////////////////////////////-->

  <!--array-->
  <xsl:template match="array">
    
    <xsl:copy>
      <xsl:copy-of select="@*"/>
      <xsl:apply-templates/>
   	</xsl:copy>

  </xsl:template>

  <!--/////////////////////////////////////////////////////////////-->

  <!--fieldValue-->
  <xsl:template match="fieldValue">

    <xsl:variable  name="rootName"    select="../../../@name"/>
    <xsl:variable  name="parentName"  select="../@name"/>
    <xsl:variable  name="parentIdx"   select="../@idx"/>
    <xsl:variable  name="currentName" select="@name"/>
    <xsl:variable  name="currentValue" select="."/>
    <xsl:variable  name="currentItem" select="position()"/>
    <xsl:variable  name="totalItems"  select="count(../*)"/>

    <xsl:choose>

      <!--Don't write Node -->
      <xsl:when test = "($rootName = 'm_Fields') and ($parentIdx = '0') and ($currentName = 'PK_FIELD')">
      </xsl:when>

      <!--Change 'name' attribute and mantain value in Node -->
      <xsl:when test = "($rootName = 'm_Fields') and ($parentIdx = '0') and ($currentName = 'Id_QUERY_FIELD')">
        
        <xsl:copy>
          <xsl:attribute name="name">
            <xsl:value-of select="'NOVO_NOME'"/>
          </xsl:attribute>

          <xsl:copy-of  select="@*[name() != 'name']"/>
          <xsl:value-of select="."/>
        </xsl:copy>

      </xsl:when>

      <!--Change value of node -->
      <xsl:when test = "($rootName = 'm_Fields') and ($parentIdx = '0') and ($currentName = 'COLOR_FIELD')">
  
        <xsl:copy>
          <xsl:copy-of select="@*"/>
          <xsl:value-of select="'novo valor'"/>
        </xsl:copy>

      </xsl:when>

      <!--write without change -->
      <xsl:otherwise>
        <xsl:copy>
          <xsl:copy-of select="@*"/>
          <xsl:value-of select="."/>
        </xsl:copy>
      </xsl:otherwise>

    </xsl:choose>


    <!--Insert New Node at Last -->
    <xsl:choose>
      
      <xsl:when test = "($rootName = 'm_Fields') and ($parentIdx = '1') and ($currentItem = $totalItems)">
        <fieldValue name="NOVOCAMPO">o meu novo campo</fieldValue>
      </xsl:when>

      <xsl:when test = "($rootName = 'm_Fields') and ($parentIdx = '1') and ($currentName = 'NOME')">
        <fieldValue name="NOVOCAMPO">o meu novo campo</fieldValue>
      </xsl:when>

    </xsl:choose>

  </xsl:template>
  
</xsl:stylesheet>



