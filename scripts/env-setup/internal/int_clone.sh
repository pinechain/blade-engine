echo ""
echo "STEP 2/2: CLONING REPOSITORIES"
echo ""

cd $BLADENG_ROOT
git clone ${REPO_URLS[$BL_GAMEDEV]}
git clone ${REPO_URLS[$BL_ANDROID]}
echo ""
echo "BLADE ENGINE WORKSPACE CLONED! PROJECTS INCLUDED:"
echo "  - ${REPO_NAMES[$BL_GAMEDEV]}"
echo "  - ${REPO_NAMES[$BL_ANDROID]}"
echo ""

cd $GAMEDEV_ROOT
git clone ${REPO_URLS[$GD_PACMAN]}
git clone ${REPO_URLS[$GD_VUESRPG]}
echo ""
echo "GAMEDEV WORKSPACE CLONED! PROJECTS INCLUDED:"
echo "  - ${REPO_NAMES[$GD_PACMAN]}"
echo "  - ${REPO_NAMES[$GD_VUESRPG]}"
echo ""

cd $ANDROID_ROOT
git clone ${REPO_URLS[$AD_SCRAPPIE]}
echo ""
echo "ANDROID WORKSPACE CLONED! PROJECTS INCLUDED:"
echo "  - ${REPO_NAMES[$AD_SCRAPPIE]}"
echo ""