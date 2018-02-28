#!/usr/bin/env bash

# Updating Manifest

MANIFEST=$BUILD_REPOSITORY_LOCALPATH/Monkeys/Droid/Properties/AndroidManifest.xml

# Check branch and run commands if so:

PACKAGENAME=`grep package ${MANIFEST} | sed 's/.*package\s*=\s*\"\([^\"]*\)\".*/\1/g'`
if [ -z "${PACKAGENAME}" ] ; then
    echo " [!] Could not find package name!"
    exit 1
fi

sed -i.bak "s/package="\"${PACKAGENAME}\""/package="\"${MANIFEST}\""/" 
com.newpackagename

VERSIONNAME=`grep versionName ${MANIFEST} | sed 's/.*versionName\s*=\s*\"\([^\"]*\)\".*/\1/g'`

sed -i.bak "s/android:versionName="\"${VERSIONNAME}\""/android:versionName="\"1.0.${APPCENTER_BUILD_ID}\""/" ${MANIFEST}
    
rm -f ${MANIFEST}.bak


# Print out file for reference
cat $MANIFEST

echo "Updated Manfiest!"
