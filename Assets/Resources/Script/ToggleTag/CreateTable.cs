using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateTable {

	public string tableName;
	public List<string> attributeNames;
	public List<string> attributeTypes;
	public List<int> attributeLengths;

	public CreateTable GetAttributeTable(){
		CreateTable tempTable = new CreateTable();
		tempTable.tableName = "attribute";
		tempTable.attributeNames = new List<string>();
		tempTable.attributeTypes = new List<string>();
		tempTable.attributeLengths = new List<int>();
		tempTable.attributeNames.Add("Nama Kelas");
		tempTable.attributeTypes.Add("varchar");
		tempTable.attributeLengths.Add(500);
		tempTable.attributeNames.Add("Atribut");
		tempTable.attributeTypes.Add("varchar");
		tempTable.attributeLengths.Add(500);
		tempTable.attributeNames.Add("Key");
		tempTable.attributeTypes.Add("varchar");
		tempTable.attributeLengths.Add(500);
		return tempTable;
	}
	public CreateTable GetProcessConstraintTable(){
		CreateTable tempTable = new CreateTable();
		tempTable.tableName = "processconstraint";
		tempTable.attributeNames = new List<string>();
		tempTable.attributeTypes = new List<string>();
		tempTable.attributeLengths = new List<int>();
		tempTable.attributeNames.Add("value");
		tempTable.attributeTypes.Add("varchar");
		tempTable.attributeLengths.Add(500);
		tempTable.attributeNames.Add("type");
		tempTable.attributeTypes.Add("varchar");
		tempTable.attributeLengths.Add(500);
		tempTable.attributeNames.Add("description");
		tempTable.attributeTypes.Add("varchar");
		tempTable.attributeLengths.Add(500);
		return tempTable;
	}
	public CreateTable GetRelationTable(){
		CreateTable tempTable = new CreateTable();
		tempTable.tableName = "relation";
		tempTable.attributeNames = new List<string>();
		tempTable.attributeTypes = new List<string>();
		tempTable.attributeLengths = new List<int>();
		tempTable.attributeNames.Add("Nama Kelas");
		tempTable.attributeTypes.Add("varchar");
		tempTable.attributeLengths.Add(500);
		tempTable.attributeNames.Add("Relasi");
		tempTable.attributeTypes.Add("varchar");
		tempTable.attributeLengths.Add(500);
		tempTable.attributeNames.Add("Melalui");
		tempTable.attributeTypes.Add("varchar");
		tempTable.attributeLengths.Add(500);
		tempTable.attributeNames.Add("Atribut");
		tempTable.attributeTypes.Add("varchar");
		tempTable.attributeLengths.Add(500);
//		tempTable.attributeNames.Add("Atribut Relasi");
//		tempTable.attributeTypes.Add("varchar");
//		tempTable.attributeLengths.Add(500);
		return tempTable;
	}

}
