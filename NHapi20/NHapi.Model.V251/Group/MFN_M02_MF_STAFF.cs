using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V251.Segment;
using NHapi.Model.V251.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V251.Group
{
///<summary>
///Represents the MFN_M02_MF_STAFF Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: MFE (Master File Entry) </li>
///<li>1: STF (Staff Identification) </li>
///<li>2: PRA (Practitioner Detail) optional repeating</li>
///<li>3: ORG (Practitioner Organization Unit) optional repeating</li>
///<li>4: AFF (Professional Affiliation) optional repeating</li>
///<li>5: LAN (Language Detail) optional repeating</li>
///<li>6: EDU (Educational Detail) optional repeating</li>
///<li>7: CER (Certificate Detail) optional repeating</li>
///<li>8: NTE (Notes and Comments) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class MFN_M02_MF_STAFF : AbstractGroup {

	///<summary> 
	/// Creates a new MFN_M02_MF_STAFF Group.
	///</summary>
	public MFN_M02_MF_STAFF(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(MFE), true, false);
	      this.add(typeof(STF), true, false);
	      this.add(typeof(PRA), false, true);
	      this.add(typeof(ORG), false, true);
	      this.add(typeof(AFF), false, true);
	      this.add(typeof(LAN), false, true);
	      this.add(typeof(EDU), false, true);
	      this.add(typeof(CER), false, true);
	      this.add(typeof(NTE), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M02_MF_STAFF - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns MFE (Master File Entry) - creates it if necessary
	///</summary>
	public MFE MFE { 
get{
	   MFE ret = null;
	   try {
	      ret = (MFE)this.GetStructure("MFE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns STF (Staff Identification) - creates it if necessary
	///</summary>
	public STF STF { 
get{
	   STF ret = null;
	   try {
	      ret = (STF)this.GetStructure("STF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of PRA (Practitioner Detail) - creates it if necessary
	///</summary>
	public PRA GetPRA() {
	   PRA ret = null;
	   try {
	      ret = (PRA)this.GetStructure("PRA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of PRA
	/// * (Practitioner Detail) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public PRA GetPRA(int rep) { 
	   return (PRA)this.GetStructure("PRA", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PRA 
	 */ 
	public int PRARepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PRA").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the PRA results 
	 */ 
	public IEnumerable<PRA> PRAs 
	{ 
		get
		{
			for (int rep = 0; rep < PRARepetitionsUsed; rep++)
			{
				yield return (PRA)this.GetStructure("PRA", rep);
			}
		}
	}

	///<summary>
	///Adds a new PRA
	///</summary>
	public PRA AddPRA()
	{
		return this.AddStructure("PRA") as PRA;
	}

	///<summary>
	///Removes the given PRA
	///</summary>
	public void RemovePRA(PRA toRemove)
	{
		this.RemoveStructure("PRA", toRemove);
	}

	///<summary>
	///Removes the PRA at the given index
	///</summary>
	public void RemovePRAAt(int index)
	{
		this.RemoveRepetition("PRA", index);
	}

	///<summary>
	/// Returns  first repetition of ORG (Practitioner Organization Unit) - creates it if necessary
	///</summary>
	public ORG GetORG() {
	   ORG ret = null;
	   try {
	      ret = (ORG)this.GetStructure("ORG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of ORG
	/// * (Practitioner Organization Unit) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public ORG GetORG(int rep) { 
	   return (ORG)this.GetStructure("ORG", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORG 
	 */ 
	public int ORGRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("ORG").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the ORG results 
	 */ 
	public IEnumerable<ORG> ORGs 
	{ 
		get
		{
			for (int rep = 0; rep < ORGRepetitionsUsed; rep++)
			{
				yield return (ORG)this.GetStructure("ORG", rep);
			}
		}
	}

	///<summary>
	///Adds a new ORG
	///</summary>
	public ORG AddORG()
	{
		return this.AddStructure("ORG") as ORG;
	}

	///<summary>
	///Removes the given ORG
	///</summary>
	public void RemoveORG(ORG toRemove)
	{
		this.RemoveStructure("ORG", toRemove);
	}

	///<summary>
	///Removes the ORG at the given index
	///</summary>
	public void RemoveORGAt(int index)
	{
		this.RemoveRepetition("ORG", index);
	}

	///<summary>
	/// Returns  first repetition of AFF (Professional Affiliation) - creates it if necessary
	///</summary>
	public AFF GetAFF() {
	   AFF ret = null;
	   try {
	      ret = (AFF)this.GetStructure("AFF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of AFF
	/// * (Professional Affiliation) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public AFF GetAFF(int rep) { 
	   return (AFF)this.GetStructure("AFF", rep);
	}

	/** 
	 * Returns the number of existing repetitions of AFF 
	 */ 
	public int AFFRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("AFF").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the AFF results 
	 */ 
	public IEnumerable<AFF> AFFs 
	{ 
		get
		{
			for (int rep = 0; rep < AFFRepetitionsUsed; rep++)
			{
				yield return (AFF)this.GetStructure("AFF", rep);
			}
		}
	}

	///<summary>
	///Adds a new AFF
	///</summary>
	public AFF AddAFF()
	{
		return this.AddStructure("AFF") as AFF;
	}

	///<summary>
	///Removes the given AFF
	///</summary>
	public void RemoveAFF(AFF toRemove)
	{
		this.RemoveStructure("AFF", toRemove);
	}

	///<summary>
	///Removes the AFF at the given index
	///</summary>
	public void RemoveAFFAt(int index)
	{
		this.RemoveRepetition("AFF", index);
	}

	///<summary>
	/// Returns  first repetition of LAN (Language Detail) - creates it if necessary
	///</summary>
	public LAN GetLAN() {
	   LAN ret = null;
	   try {
	      ret = (LAN)this.GetStructure("LAN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of LAN
	/// * (Language Detail) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public LAN GetLAN(int rep) { 
	   return (LAN)this.GetStructure("LAN", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LAN 
	 */ 
	public int LANRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("LAN").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the LAN results 
	 */ 
	public IEnumerable<LAN> LANs 
	{ 
		get
		{
			for (int rep = 0; rep < LANRepetitionsUsed; rep++)
			{
				yield return (LAN)this.GetStructure("LAN", rep);
			}
		}
	}

	///<summary>
	///Adds a new LAN
	///</summary>
	public LAN AddLAN()
	{
		return this.AddStructure("LAN") as LAN;
	}

	///<summary>
	///Removes the given LAN
	///</summary>
	public void RemoveLAN(LAN toRemove)
	{
		this.RemoveStructure("LAN", toRemove);
	}

	///<summary>
	///Removes the LAN at the given index
	///</summary>
	public void RemoveLANAt(int index)
	{
		this.RemoveRepetition("LAN", index);
	}

	///<summary>
	/// Returns  first repetition of EDU (Educational Detail) - creates it if necessary
	///</summary>
	public EDU GetEDU() {
	   EDU ret = null;
	   try {
	      ret = (EDU)this.GetStructure("EDU");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of EDU
	/// * (Educational Detail) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public EDU GetEDU(int rep) { 
	   return (EDU)this.GetStructure("EDU", rep);
	}

	/** 
	 * Returns the number of existing repetitions of EDU 
	 */ 
	public int EDURepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("EDU").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the EDU results 
	 */ 
	public IEnumerable<EDU> EDUs 
	{ 
		get
		{
			for (int rep = 0; rep < EDURepetitionsUsed; rep++)
			{
				yield return (EDU)this.GetStructure("EDU", rep);
			}
		}
	}

	///<summary>
	///Adds a new EDU
	///</summary>
	public EDU AddEDU()
	{
		return this.AddStructure("EDU") as EDU;
	}

	///<summary>
	///Removes the given EDU
	///</summary>
	public void RemoveEDU(EDU toRemove)
	{
		this.RemoveStructure("EDU", toRemove);
	}

	///<summary>
	///Removes the EDU at the given index
	///</summary>
	public void RemoveEDUAt(int index)
	{
		this.RemoveRepetition("EDU", index);
	}

	///<summary>
	/// Returns  first repetition of CER (Certificate Detail) - creates it if necessary
	///</summary>
	public CER GetCER() {
	   CER ret = null;
	   try {
	      ret = (CER)this.GetStructure("CER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CER
	/// * (Certificate Detail) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CER GetCER(int rep) { 
	   return (CER)this.GetStructure("CER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CER 
	 */ 
	public int CERRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("CER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CER results 
	 */ 
	public IEnumerable<CER> CERs 
	{ 
		get
		{
			for (int rep = 0; rep < CERRepetitionsUsed; rep++)
			{
				yield return (CER)this.GetStructure("CER", rep);
			}
		}
	}

	///<summary>
	///Adds a new CER
	///</summary>
	public CER AddCER()
	{
		return this.AddStructure("CER") as CER;
	}

	///<summary>
	///Removes the given CER
	///</summary>
	public void RemoveCER(CER toRemove)
	{
		this.RemoveStructure("CER", toRemove);
	}

	///<summary>
	///Removes the CER at the given index
	///</summary>
	public void RemoveCERAt(int index)
	{
		this.RemoveRepetition("CER", index);
	}

	///<summary>
	/// Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
	///</summary>
	public NTE GetNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NTE
	/// * (Notes and Comments) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NTE GetNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the NTE results 
	 */ 
	public IEnumerable<NTE> NTEs 
	{ 
		get
		{
			for (int rep = 0; rep < NTERepetitionsUsed; rep++)
			{
				yield return (NTE)this.GetStructure("NTE", rep);
			}
		}
	}

	///<summary>
	///Adds a new NTE
	///</summary>
	public NTE AddNTE()
	{
		return this.AddStructure("NTE") as NTE;
	}

	///<summary>
	///Removes the given NTE
	///</summary>
	public void RemoveNTE(NTE toRemove)
	{
		this.RemoveStructure("NTE", toRemove);
	}

	///<summary>
	///Removes the NTE at the given index
	///</summary>
	public void RemoveNTEAt(int index)
	{
		this.RemoveRepetition("NTE", index);
	}

}
}
