/**
 * GetItemForConsoleResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetItemForConsoleResponse  implements java.io.Serializable {
    private java.lang.String getItemForConsoleResult;

    public GetItemForConsoleResponse() {
    }

    public GetItemForConsoleResponse(
           java.lang.String getItemForConsoleResult) {
           this.getItemForConsoleResult = getItemForConsoleResult;
    }


    /**
     * Gets the getItemForConsoleResult value for this GetItemForConsoleResponse.
     * 
     * @return getItemForConsoleResult
     */
    public java.lang.String getGetItemForConsoleResult() {
        return getItemForConsoleResult;
    }


    /**
     * Sets the getItemForConsoleResult value for this GetItemForConsoleResponse.
     * 
     * @param getItemForConsoleResult
     */
    public void setGetItemForConsoleResult(java.lang.String getItemForConsoleResult) {
        this.getItemForConsoleResult = getItemForConsoleResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetItemForConsoleResponse)) return false;
        GetItemForConsoleResponse other = (GetItemForConsoleResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getItemForConsoleResult==null && other.getGetItemForConsoleResult()==null) || 
             (this.getItemForConsoleResult!=null &&
              this.getItemForConsoleResult.equals(other.getGetItemForConsoleResult())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getGetItemForConsoleResult() != null) {
            _hashCode += getGetItemForConsoleResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetItemForConsoleResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetItemForConsoleResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getItemForConsoleResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetItemForConsoleResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }

}
