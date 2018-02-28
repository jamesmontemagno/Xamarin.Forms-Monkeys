#!/usr/bin/env bash

if [ ! -f "$BUILD_REPOSITORY_LOCALPATH/Monkeys/iOS/Info.plist" ] ; then
  echo " [!] File doesn't exist at specified Info.Plist path"
  exit 1
fi

PLIST=$BUILD_REPOSITORY_LOCALPATH/Monkeys/iOS/Info.plist

/usr/libexec/PlistBuddy -c "Set :CFBundleIdentifier com.test" $PLIST
# Print out file for reference
cat $PLIST

echo "Updated info.plist!"
